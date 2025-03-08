using System;

namespace shopinventory
{
    class MainClass
    {
        static Shop shop = new Shop(); // Create a shop instance

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            for (int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }

            // MARK: Result
            Console.WriteLine("Retrieve all stored items:");
            GetAllItems();
        }

        // MARK: Add an item to the shop
        public static void AddItem(int index, string name)
        {
            try
            {
                shop[index] = name;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // MARK: Retrieve all stored items
        public static void GetAllItems()
        {
            foreach (var kvp in shop.GetInventory())
            {
                Console.WriteLine($"ID: {kvp.Key}, Item: {kvp.Value}");
            }
        }
    }
}
