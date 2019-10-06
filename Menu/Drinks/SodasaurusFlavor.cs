/*  SodasaurusFlavor.cs
*   Author: Andrew Booze
*/

using System;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An enum which expresses which flavor the soda is. Can be used as bit flags.
    /// </summary>
    [Flags]
    public enum SodasaurusFlavor
    {
        /// <summary>
        /// Generic Cola flavor
        /// </summary>
        Cola = 1,

        /// <summary>
        /// Orange flavor
        /// </summary>
        Orange = 2,

        /// <summary>
        /// Vanilla flavor
        /// </summary>
        Vanilla = 4,

        /// <summary>
        /// Chocolate flavor
        /// </summary>
        Chocolate = 8,

        /// <summary>
        /// Root Beer soda
        /// </summary>
        RootBeer = 16,

        /// <summary>
        /// Cherry flavor
        /// </summary>
        Cherry = 32,

        /// <summary>
        /// Lime flavor
        /// </summary>
        Lime = 64,

        /// <summary>
        /// Grape flavor
        /// </summary>
        Grape = 128
    }
}
