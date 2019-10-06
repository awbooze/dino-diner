/*  Entree.cs
*   Author: Andrew Booze
*/

namespace DinoDiner.Menu
{
    /// <summary>
    /// The base class for all entrees.
    /// </summary>
    public abstract class Entree : MenuItem
    {
        // This isn't really useful because nothing is in the entree that isn't in the menu item at this time.
        // Since it inherits from MenuItem, it still provides price, calories, and ingredients to Entrees and so 
        // satisfies the requirements for this class.
    }
}
