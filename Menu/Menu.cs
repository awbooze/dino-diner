/*  Menu.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class which represents the entire menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Generates and returns a list of all available menu items.
        /// </summary>
        public List<MenuItem> AvailableMenuItems
        {
            get
            {
                List<MenuItem> menuItems = new List<MenuItem>();
                menuItems.AddRange(AvailableCombos);
                menuItems.AddRange(AvailableEntrees);
                menuItems.AddRange(AvailableSides);
                menuItems.AddRange(AvailableDrinks);
                return menuItems;
            }
        }

        /// <summary>
        /// Generates and returns a list of all available entrees on the menu.
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                return new List<Entree>
                {
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new Brontowurst(),
                    new PterodactylWings(),
                    new DinoNuggets(),
                    new VelociWrap(),
                    new PrehistoricPBJ()
                };
            }
        }

        /// <summary>
        /// Generates and returns a list of all available sides on the menu.
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                return new List<Side>
                {
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
        }

        /// <summary>
        /// Generates and returns a list of all available drinks on the menu.
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                return new List<Drink>
                {
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water()
                };
            }
        }

        /// <summary>
        /// Generates and returns a list of all available combos on the menu.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();

                foreach (Entree entree in AvailableEntrees)
                {
                    combos.Add(new CretaceousCombo(entree));
                }

                return combos;
            }
        }

        /// <summary>
        /// Returns the entire contents of the menu separated by new line characters.
        /// </summary>
        /// <returns>A list of all menu contents separated by new line characters.</returns>
        public override string ToString()
        {
            string menuContents = "";

            foreach (dynamic item in AvailableMenuItems)
            {
                menuContents += item + "\n";
            }

            return menuContents;
        }
    }
}
