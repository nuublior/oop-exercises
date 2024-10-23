namespace _23._1_InventorySystemPolymorphism;

public class Program
{
    
    public static void Main(string[] args)
    {
        // Create a new Inventory
        Inventory myInventory = new Inventory(10);

        // Add FoodItem and NonFoodItem to the inventory
        myInventory.AddItem(new FoodItem("Apple", 5.0, DateTime.Now.AddDays(7)));
        myInventory.AddItem(new NonFoodItem("Laptop", 1000.0, new string[] { "metal", "plastic" }));

        // Print the inventory
        myInventory.PrintInventory();

        // Get the total inventory value
        Console.WriteLine("Total Inventory Value: " + myInventory.GetInventoryValue());
        
        
    }
}