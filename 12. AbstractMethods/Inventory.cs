namespace _12._AbstractMethods
{
    // Inventory class to manage a collection of items, including adding and removing expired items.
    public class Inventory
    {
        // Array to store Item objects, both FoodItem and NonFoodItem types.
        private Item[] items;

        // Constructor to initialize the inventory with a fixed size.
        public Inventory(int size)
        {
            items = new Item[size];  // Creates an array with the specified size.
        }

        // Method to add a new item to the inventory.
        public void AddItem(Item item)
        {
            // Loop through the items array to find an empty slot.
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)  // Check if the slot is empty.
                {
                    items[i] = item;  // Add the new item in the first empty slot found.
                    break;  // Exit the loop once the item is added.
                }
            }
        }

        // Method to remove expired items from the inventory.
        public void RemoveExpiredFoods()
        {
            // Loop through the items array to check each item for expiration.
            for (int i = 0; i < items.Length; i++)
            {
                // Check if the item exists and if it is expired.
                if (items[i] != null && items[i].IsExpired())
                {
                    items[i] = null;  // Remove the expired item by setting its slot to null.
                }
            }
        }

        // Method to calculate and return the total value of all items in the inventory.
        public double GetInventoryValue()
        {
            double totalValue = 0;  // Initialize total value to zero.
            
            // Iterate over each item in the inventory.
            foreach (Item item in items)
            {
                // If the item slot is not empty, add its price to the total value.
                if (item != null)
                {
                    totalValue += item.GetPrice();
                }
            }

            return totalValue;  // Return the total value of all items.
        }

        // Method to print out each item in the inventory.
        public void PrintInventory()
        {
            // Iterate over each item in the inventory.
            foreach (Item item in items)
            {
                // If the item slot is not empty, print the item's details.
                if (item != null)
                {
                    Console.WriteLine(item.ToString());  // Print the item details.
                }
            }
        }
    }
}
