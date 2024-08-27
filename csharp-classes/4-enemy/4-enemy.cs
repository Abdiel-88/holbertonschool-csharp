using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie with health and a name.
    /// </summary>
    public class Zombie
    {
        // Private fields to hold the health and name of the Zombie.
        private int health;
        private string name = "(No name)";

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class and sets health to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with specified health value.
        /// </summary>
        /// <param name="value">The health value. Must be greater than or equal to 0.</param>
        /// <exception cref="ArgumentException">Thrown when the value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Gets or sets the name of the Zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the health of the Zombie.
        /// </summary>
        /// <returns>The health of the Zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
