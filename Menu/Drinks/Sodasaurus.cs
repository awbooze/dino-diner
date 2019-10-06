/*  Sodasaurus.cs
*   Author: Andrew Booze
*/

using System;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A drink class that represents a cup of various types of soda.
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size;

        /// <summary>
        /// An enum variable which stores the size of this drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;

                switch (value)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }

        /// <summary>
        /// A list of ingredients for this drink.
        /// </summary>
        public override List<string> Ingredients => new List<string> { "Water", "Natural Flavors", "Cane Sugar" };

        /// <summary>
        /// The flavor or flavors of this soda. Use the bitwise OR operator to set multiple flavors.
        /// Defaults to the generic cola flavor only.
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; } = SodasaurusFlavor.Cola;

        /// <summary>
        /// The constructor for the Sodasaurus drink.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
        }

        /// <summary>
        /// Creates and returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            string toReturn = Size.ToString();

            if (Flavor.HasFlag(SodasaurusFlavor.Cola))
            {
                toReturn += " Cola";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.Orange))
            {
                toReturn += " Orange";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.Vanilla))
            {
                toReturn += " Vanilla";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.Chocolate))
            {
                toReturn += " Chocolate";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.RootBeer))
            {
                toReturn += " RootBeer";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.Cherry))
            {
                toReturn += " Cherry";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.Lime))
            {
                toReturn += " Lime";
            }
            if (Flavor.HasFlag(SodasaurusFlavor.Grape))
            {
                toReturn += " Grape";
            }

            toReturn += " Sodasaurus";
            return toReturn;
        }
    }
}
