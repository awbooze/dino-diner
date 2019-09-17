/*  PrehistoricPBJ.cs
*   Modified by: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// An entree class for the Prehistoric PB&J.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// The list of ingrediants for this PB&J.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for this PB&J
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }

        /// <summary>
        /// Allows the user to remove the peanut butter from this PB&J.
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
        }

        /// <summary>
        /// Allows the user to remove the jelly from this PB&J.
        /// </summary>
        public void HoldJelly()
        {
            jelly = false;
        }
    }
}
