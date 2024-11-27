using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents a user in the inventory system.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>Name of the user (required).</summary>
        public string name { get; set; }

        /// <summary>
        /// Constructor initializes the required name property.
        /// </summary>
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required for a user.");
            
            this.name = name;
        }
    }
}
