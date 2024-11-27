using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>Name of the item (required).</summary>
        public string name { get; set; }

        /// <summary>Optional description of the item.</summary>
        public string? description { get; set; }

        /// <summary>Price of the item, limited to 2 decimal points.</summary>
        private float _price;
        public float price
        {
            get => _price;
            set => _price = (float)Math.Round(value, 2); // Round to 2 decimal points
        }

        /// <summary>Tags associated with the item.</summary>
        public List<string> tags { get; set; }

        /// <summary>
        /// Constructor initializes required properties.
        /// </summary>
        public Item(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required for an item.");
            
            this.name = name;
            this.tags = new List<string>();
        }
    }
}
