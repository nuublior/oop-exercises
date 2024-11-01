namespace _12._AbstractMethods
{
    public abstract class Item : IExpireable
    {
        public string name;
        public double price;

        public Item(string nameValue, double priceValue)
        {
            name = nameValue;
            price = priceValue;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        // Implementing IsExpired from IExpireable interface
        public abstract bool IsExpired();
    }
}