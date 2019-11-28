/*  Menu.cs
*   Author: Andrew Booze
*/

using System;
using System.Collections.Generic;
using System.Linq;

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
                    new Sodasaurus(),
                    new JurassicJava(),
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
        /// Creates and returns a list of all ingredients of all menu items without duplicates.
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                HashSet<string> ingredientsWithoutDuplication = new HashSet<string>();

                foreach (MenuItem item in AvailableMenuItems)
                {
                    ingredientsWithoutDuplication.UnionWith(item.Ingredients);
                }

                List<string> toReturn = ingredientsWithoutDuplication.OrderBy(ingredient => ingredient).ToList();
                return toReturn;
            }
        }

        /// <summary>
        /// Searches the description of the menu item for the specified search term.
        /// </summary>
        /// <typeparam name="T">Any derived class of MenuItem.</typeparam>
        /// <param name="menuItems">A list of menu items.</param>
        /// <param name="searchTerm">The search term.</param>
        /// <returns>A new list of the same type of items which satisfies the condition.</returns>
        public static List<T> Search<T>(List<T> menuItems, string searchTerm) where T : MenuItem
        {
            List<T> results = new List<T>();

            foreach (T item in menuItems)
            {
                if (item.Description.ToLower().Contains(searchTerm.ToLower()))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided list of menu items by their minimum price.
        /// </summary>
        /// <typeparam name="T">Any derived class of MenuItem.</typeparam>
        /// <param name="menuItems">A list of menu items.</param>
        /// <param name="min">The minimum price to filter by.</param>
        /// <returns>A new list of the same type of items which satisfies the condition.</returns>
        public static List<T> FilterByMinimumPrice<T>(List<T> menuItems, float min) where T : MenuItem
        {
            List<T> results = new List<T>();

            foreach (T item in menuItems)
            {
                if (item.Price >= min)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided list of menu items by their maximum price.
        /// </summary>
        /// <typeparam name="T">Any derived class of MenuItem.</typeparam>
        /// <param name="menuItems">A list of menu items.</param>
        /// <param name="max">The maximum price to filter by.</param>
        /// <returns>A new list of the same type of items which satisfies the condition.</returns>
        public static List<T> FilterByMaximumPrice<T>(List<T> menuItems, float max) where T : MenuItem
        {
            List<T> results = new List<T>();

            foreach (T item in menuItems)
            {
                if (item.Price <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided list of menu items to exclude menu items which contain ingredients in 
        /// the provided list.
        /// </summary>
        /// <typeparam name="T">Any derived class of MenuItem.</typeparam>
        /// <param name="menuItems">A list of menu items.</param>
        /// <param name="excludedIngredients">A list of the ingredients to exclude.</param>
        /// <returns>A new list of the same type of items which satisfies the condition.</returns>
        public static List<T> FilterByExcludedIngredients<T>(List<T> menuItems, List<string> excludedIngredients) 
            where T : MenuItem
        {
            List<T> results = new List<T>();

            foreach (T item in menuItems)
            {
                bool passesFilter = true;

                foreach (string ingredient in excludedIngredients)
                {
                    if (item.Ingredients.Contains(ingredient))
                    {
                        passesFilter = false;
                        break;
                    }
                }

                if (passesFilter)
                {
                    results.Add(item);
                }
            }

            return results;
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
