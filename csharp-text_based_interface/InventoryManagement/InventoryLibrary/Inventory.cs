using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an inventory entry.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>User ID associated with the inventory entry (required).</summary>
        public string user_id { get; set; }

        /// <summary>Item ID associated with the inventory entry (required).</summary>
        public string item_id { get; set; }

        /// <summary>Quantity of the item in the inventory.</summary>
        private int _quantity;
        public int quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be less than 0.");
                _quantity = value;
            }
        }

        /// <summary>
        /// Constructor initializes required properties with default quantity.
        /// </summary>
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(user_id))
                throw new ArgumentException("User ID is required for an inventory entry.");
            if (string.IsNullOrWhiteSpace(item_id))
                throw new ArgumentException("Item ID is required for an inventory entry.");

            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }
    }
}
