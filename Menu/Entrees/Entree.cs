using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The base class for all entrees. Provides Price, Calories, and abstract Ingredent list to entrees. 
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of this entree.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The number of calories in this entree.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The list of ingredients for this entree.
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
