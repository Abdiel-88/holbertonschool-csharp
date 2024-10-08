﻿using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Health of the Zombie.
        /// </summary>
        public int health;

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
    }
}
