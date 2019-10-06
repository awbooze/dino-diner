/*  Side.cs
*   Modified by: Andrew Booze
*/

namespace DinoDiner.Menu
{
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
