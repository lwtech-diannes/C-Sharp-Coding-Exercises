using System;
using System.Collections.Generic;

namespace shopinventory
{
    public class Shop
    {
        private Dictionary<int, string> inventory = new Dictionary<int, string>();

        public string this[int id]
        {
            get
            {
                if (inventory.TryGetValue(id, out string item))
                    return item;
                throw new KeyNotFoundException($"Error: Item with ID {id} does not exist.");
            }
            set
            {
                if (inventory.ContainsValue(value))
                    throw new ArgumentException($"Error: Item \"{value}\" already exists in the inventory.");

                inventory[id] = value;
            }
        }

        public Dictionary<int, string> GetInventory()
        {
            return inventory;
        }
    }
}
