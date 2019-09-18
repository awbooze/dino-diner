/*  Side.cs
*   Modified by: Andrew Booze
*/

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
    public abstract class Side : MenuItem
    {
        /// <summary>
        /// Gets or sets the size of this side.
        /// </summary>
        public abstract Size Size { get; set; }
    }
}
