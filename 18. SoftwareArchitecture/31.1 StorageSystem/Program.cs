namespace Data
{
    public class FileBackend
    {
        private string _filename;

        public FileBackend(string filename)
        {
            _filename = filename;
        }

        public bool Store(List<string> entries)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_filename))
                {
                    foreach (string entry in entries)
                    {
                        writer.WriteLine(entry);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public List<string> Load()
        {
            List<string> entries = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(_filename))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        entries.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<string>();
            }
            return entries;
        }
    }
}

namespace Domain
{
    abstract class Item : IComparable<Item>
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract bool IsExpired();
        public abstract string GetItemType();
        public abstract string[] GetState();

        public string Marshal()
        {
            string type = GetItemType();
            string[] parameters = GetState();
            return type + " " + string.Join(" ", parameters);
        }

        public static Item? Unmarshal(string input)
        {
            string[] args = input.Split(' ');
            string type = args[0];

            switch (type)
            {
                case "FoodItem":
                    return FoodItem.Unmarshal(args);
                case "NonFoodItem":
                    return NonFoodItem.Unmarshal(args);
                default:
                    return null;
            }
        }

        public int CompareTo(Item? it)
        {
            if (it == null) return -1;
            double tmp = Price - it.Price;
            if (tmp < 0) return -1;
            else if (tmp > 0) return 1;
            else return 0;
        }
    }

    class FoodItem : Item
    {
        private DateTime _expiresAt;

        public FoodItem(string name, double price, DateTime expiresAt)
            : base(name, price)
        {
            _expiresAt = expiresAt;
            if (IsExpired())
            {
                throw new ExpiredItemAddedException();
            }
        }

        public override string ToString()
        {
            return $"FoodItem name='{Name}' price='{Price}' ExpiresAt='{_expiresAt}'";
        }

        public override bool IsExpired()
        {
            return _expiresAt.CompareTo(DateTime.Now) < 0;
        }

        public override string GetItemType()
        {
            return "FoodItem";
        }

        public override string[] GetState()
        {
            return new string[] { Name, Price.ToString(), _expiresAt.ToString() };
        }

        public static FoodItem? Unmarshal(string[] args)
        {
            if (args.Length != 4) return null;
            string name = args[1];
            double price = double.Parse(args[2]);
            DateTime date;
            try
            {
                date = DateTime.Parse(args[3]);
            }
            catch (FormatException)
            {
                return null;
            }
            try
            {
                return new FoodItem(name, price, date);
            }
            catch (ExpiredItemAddedException)
            {
                return null;
            }
        }
    }

    class NonFoodItem : Item
    {
        public List<string> Materials { get; private set; }

        public NonFoodItem(string name, double price, List<string> materials)
            : base(name, price)
        {
            Materials = materials;
        }

        public NonFoodItem(string name, double price, string[] materials)
            : base(name, price)
        {
            Materials = new List<string>(materials);
        }

        public override bool IsExpired()
        {
            throw new NotSupportedException("Item does not support this operation.");
        }

        public override string ToString()
        {
            return $"NonFoodItem name='{Name}' price='{Price}' Materials='[{string.Join(",", Materials)}]'";
        }

        public override string GetItemType()
        {
            return "NonFoodItem";
        }

        public override string[] GetState()
        {
            return new string[] { Name, Price.ToString(), string.Join(",", Materials) };
        }

        public static NonFoodItem? Unmarshal(string[] args)
        {
            if (args.Length != 4) return null;
            string name = args[1];
            double price = double.Parse(args[2]);
            string[] materials = args[3].Split(',');
            return new NonFoodItem(name, price, materials);
        }
    }

    class ExpiredItemAddedException : Exception
    {
        public ExpiredItemAddedException()
            : base("Attempted to add expired product to database")
        {
        }
    }

    class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool Load(string filename)
        {
            Data.FileBackend fb = new Data.FileBackend(filename);
            if (fb == null) return false;
            List<string> entries = fb.Load();
            if (entries == null) return false;

            foreach (string entry in entries)
            {
                Item? item = Item.Unmarshal(entry);
                if (item != null) AddItem(item);
            }
            return true;
        }

        public bool Store(string filename)
        {
            Data.FileBackend fb = new Data.FileBackend(filename);
            if (fb == null) return false;
            List<string> entries = new List<string>();
            foreach (Item item in _items)
            {
                entries.Add(item.Marshal());
            }
            return fb.Store(entries);
        }

        public void AddItem(Item item)
        {
            if (_items.Any(existingItem => existingItem.Name == item.Name && existingItem.Price == item.Price && existingItem.GetType() == item.GetType()))
            {
                return;
            }
            _items.Add(item);
        }

        public void PrintInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (Item item in _items)
            {
                Console.WriteLine(" - " + item);
            }
        }
    }

    public class Domain : Interface.IDomain
    {
        private string filename;
        private Inventory inventory;

        public Domain(string filename)
        {
            this.filename = filename;
            inventory = new Inventory();
        }

        public void Load()
        {
            inventory.Load(filename);
        }

        public void Store()
        {
            inventory.Store(filename);
        }

        public void AddNonFoodItem(string name, double price, string[] materials)
        {
            NonFoodItem item = new NonFoodItem(name, price, materials);
            inventory.AddItem(item);
        }

        public void PrintInventory()
        {
            inventory.PrintInventory();
        }
    }
}

namespace Presentation
{
    using Interface;

    class Test
    {
        private static IDomain domain = new Domain.Domain("inventory.txt");

        public static void Add()
        {
            domain.AddNonFoodItem("USB_Charger", 17.45, new string[] { "plastic", "stuff" });
            domain.Store();
        }

        public static void List()
        {
            domain.Load();
            domain.PrintInventory();
        }

        public static void Main(string[] args)
        {
            Add();
            List();
        }
    }
}

namespace Interface
{
    public interface IDomain
    {
        public void Load();
        public void Store();
        public void AddNonFoodItem(string name, double price, string[] materials);
        public void PrintInventory();
    }
}
