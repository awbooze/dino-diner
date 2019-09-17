/*  Side.cs
*   Modified by: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// An enum with one of three side sizes: small, medium, or large.
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// The small size.
        /// </summary>
        Small,

        /// <summary>
        /// The medium size.
        /// </summary>
        Medium,

        /// <summary>
        /// The large size.
        /// </summary>
        Large
    }

    /// <summary>
    /// The abstract base class for all sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price of this side.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories of this side.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list of this side.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size of this side.
        /// </summary>
        public abstract Size Size { get; set; }
    }
}
