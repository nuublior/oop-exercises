namespace _19._1_InventorySystemInheritance 
{
    public class Item
    {
        // Fields for name and price
        protected readonly string Name;
        protected readonly double Price;

        // Constructor
        protected Item(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }
    }

    public class FoodItem : Item
    {
        // Field for expiration date
        private readonly DateTime _expires;

        public FoodItem(string name, double price, DateTime expires)
            : base(name, price)
        {
            _expires = expires;
        }

        public DateTime GetExpires()
        {
            return _expires;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Expires: {_expires.ToShortDateString()}";
        }
    }

    public class NonFoodItem : Item
    {
        // Field for materials
        private readonly string[] _materials;

        public NonFoodItem(string name, double price, string[] materials)
            : base(name, price)
        {
            _materials = materials;
        }

        public string[] GetMaterials()
        {
            return _materials;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Materials: {string.Join(", ", _materials)}";
        }
    }

    class Program
    {
        static void Main()
        {
            // Delopgave 2: FoodItems

            // Step 1: Create an array to hold 10 FoodItem objects
            FoodItem[] foodItems = new FoodItem[10];

            // Step 2: First loop to fill the array with FoodItem objects
            for (int i = 0; i < foodItems.Length; i++)
            {
                // Creating FoodItem objects and filling the array
                foodItems[i] = new FoodItem($"Apple {i + 1}", 1.00 + i, DateTime.Now.AddDays(i));
            }

            // Step 3: Second loop to print each FoodItem using the ToString method
            for (int i = 0; i < foodItems.Length; i++)
            {
                Console.WriteLine(foodItems[i].ToString());
            }

            // Delopgave 3: NonFoodItems

            // Step 1: Create an array to hold 10 NonFoodItem objects
            NonFoodItem[] nonFoodItems = new NonFoodItem[10];

            // Step 2: First loop to fill the array with NonFoodItem objects
            for (int i = 0; i < nonFoodItems.Length; i++)
            {
                // Creating NonFoodItem objects and filling the array
                nonFoodItems[i] = new NonFoodItem($"Chair {i + 1}", 49.99 + (i * 10), new string[] { "Wood", "Metal" });
            }

            // Step 3: Second loop to print each NonFoodItem using the ToString method
            for (int i = 0; i < nonFoodItems.Length; i++)
            {
                Console.WriteLine(nonFoodItems[i].ToString());
            }
        }
    }
}
