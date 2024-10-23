namespace _23._1_InventorySystemPolymorphism;

public class Inventory
{
    // Attribute: An array to hold Items (both FoodItem and NonFoodItem)
    private Item[] items;

    // Constructor to initialize the array (e.g., with a size of 10)
    public Inventory(int size)
    {
        items = new Item[size];  // Initialize the array with a fixed size
    }

    // Add an item to the inventory
    public void AddItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null) // Find an empty spot
            {
                items[i] = item;
                break;
            }
        }
    }

    // Remove an item from the inventory
    public void RemoveItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item) // Find the matching item
            {
                items[i] = null;
                break;
            }
        }
    }

    // Get the total value of the inventory
    public double GetInventoryValue()
    {
        double totalValue = 0;
    
        foreach (Item item in items)
        {
            if (item != null) // Make sure to handle any empty/null items
            {
                totalValue += item.GetPrice();
            }
        }
    
        return totalValue;
    }


    // Print all items in the inventory
    public void PrintInventory()
    {
        foreach (Item item in items)
        {
            if (item != null)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}
