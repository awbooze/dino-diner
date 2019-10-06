/*  JurrassicJava.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A drink class that represents a cup of coffee.
    /// </summary>
    public class JurassicJava : Drink
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// A list of ingredients for this drink.
        /// </summary>
        public override List<string> Ingredients => new List<string> { "Water", "Coffee" };

        /// <summary>
        /// An overridden ice variable which defaults to false.
        /// </summary>
        public override bool Ice { get; protected set; } = false;

        /// <summary>
        /// Whether the server should leave room for cream in this coffee. 
        /// Sadly, does not decrease the price. Defaults to false.
        /// </summary>
        public bool RoomForCream { get; private set; } = false;

        /// <summary>
        /// Whether this coffee is decalf. Defaults to false.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// The constructor for the JurassicJava drink.
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
        }

        /// <summary>
        /// Allows the user to add ice to this drink.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }

        /// <summary>
        /// Directs the server to leave room for cream.
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        /// <summary>
        /// Makes this coffee decalf.
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
        }
    }
}
