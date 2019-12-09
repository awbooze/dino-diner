/*  Menu.cshtml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Website.Pages
{
    /// <summary>
    /// The Model class for the Menu page.
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// The menu object created for this menu page.
        /// </summary>
        public Menu Menu { get; private set; } = null;

        /// <summary>
        /// A list of available combos for the menu page.
        /// </summary>
        public IEnumerable<CretaceousCombo> AvailableCombos { get; private set; } = null;

        /// <summary>
        /// A list of available entrees for the menu page.
        /// </summary>
        public IEnumerable<Entree> AvailableEntrees { get; private set; } = null;

        /// <summary>
        /// A list of available sides for the menu page.
        /// </summary>
        public IEnumerable<Side> AvailableSides { get; private set; } = null;

        /// <summary>
        /// A list of available drinks for the menu page.
        /// </summary>
        public IEnumerable<Drink> AvailableDrinks { get; private set; } = null;

        /// <summary>
        /// The search term when a search is executed through the search and filter button.
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// A list of food categories set when a search is executed.
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        /// <summary>
        /// A nullable minimum price set when a search is executed.
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }

        /// <summary>
        /// A nullable maximum price set when a search is executed.
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }

        /// <summary>
        /// A list of excluded ingredients set when a search is executed.
        /// </summary>
        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();

        /// <summary>
        /// Method executed whenever a get request is recieved to get the current page. 
        /// Creates a reference to the Menu object and assigns it to the Menu variable.
        /// </summary>
        public void OnGet()
        {
            if (Menu == null)
            {
                Menu = new Menu();
            }

            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;
        }

        /// <summary>
        /// Method executed whenever a post request is recieved for the current page. Searches and filters 
        /// the menu items on the page and then returns the ones that match the filters.
        /// </summary>
        public void OnPost()
        {
            if (Menu == null)
            {
                Menu = new Menu();
            }

            AvailableCombos = Menu.AvailableCombos;
            AvailableEntrees = Menu.AvailableEntrees;
            AvailableSides = Menu.AvailableSides;
            AvailableDrinks = Menu.AvailableDrinks;

            if (search != null)
            {
                //AvailableCombos = Menu.Search(AvailableCombos, search);
                AvailableCombos = AvailableCombos.Where(item => item.Description.Contains(search, 
                    StringComparison.CurrentCultureIgnoreCase));

                //AvailableEntrees = Menu.Search(AvailableEntrees, search);
                AvailableEntrees = AvailableEntrees.Where(item => item.Description.Contains(search,
                    StringComparison.CurrentCultureIgnoreCase));

                //AvailableSides = Menu.Search(AvailableSides, search);
                AvailableSides = AvailableSides.Where(item => item.Description.Contains(search,
                    StringComparison.CurrentCultureIgnoreCase));

                //AvailableDrinks = Menu.Search(AvailableDrinks, search);
                AvailableDrinks = AvailableDrinks.Where(item => item.Description.Contains(search,
                    StringComparison.CurrentCultureIgnoreCase));
            }

            if (menuCategory.Count > 0)
            {
                if (!menuCategory.Contains("Combo"))
                {
                    AvailableCombos = new List<CretaceousCombo>();
                }

                if (!menuCategory.Contains("Entree"))
                {
                    AvailableEntrees = new List<Entree>();
                }

                if (!menuCategory.Contains("Side"))
                {
                    AvailableSides = new List<Side>();
                }

                if (!menuCategory.Contains("Drink"))
                {
                    AvailableDrinks = new List<Drink>();
                }
            }

            if (minimumPrice is float min)
            {
                //AvailableCombos = Menu.FilterByMinimumPrice(AvailableCombos, min);
                AvailableCombos = AvailableCombos.Where(item => item.Price >= min);

                //AvailableEntrees = Menu.FilterByMinimumPrice(AvailableEntrees, min);
                AvailableEntrees = AvailableEntrees.Where(item => item.Price >= min);

                //AvailableSides = Menu.FilterByMinimumPrice(AvailableSides, min);
                AvailableSides = AvailableSides.Where(item => item.Price >= min);

                //AvailableDrinks = Menu.FilterByMinimumPrice(AvailableDrinks, min);
                AvailableDrinks = AvailableDrinks.Where(item => item.Price >= min);
            }

            if (maximumPrice is float max)
            {
                //AvailableCombos = Menu.FilterByMaximumPrice(AvailableCombos, max);
                AvailableCombos = AvailableCombos.Where(item => item.Price <= max);

                //AvailableEntrees = Menu.FilterByMaximumPrice(AvailableEntrees, max);
                AvailableEntrees = AvailableEntrees.Where(item => item.Price <= max);

                //AvailableSides = Menu.FilterByMaximumPrice(AvailableSides, max);
                AvailableSides = AvailableSides.Where(item => item.Price <= max);

                //AvailableDrinks = Menu.FilterByMaximumPrice(AvailableDrinks, max);
                AvailableDrinks = AvailableDrinks.Where(item => item.Price <= max);
            }

            if (excludedIngredients.Count > 0)
            {
                //AvailableCombos = Menu.FilterByExcludedIngredients(AvailableCombos, excludedIngredients);
                AvailableCombos = AvailableCombos.Where(item =>
                {
                    foreach (string ingredient in excludedIngredients)
                    {
                        if (item.Ingredients.Contains(ingredient)) {
                            return false;
                        }
                    }

                    return true;
                });

                //AvailableEntrees = Menu.FilterByExcludedIngredients(AvailableEntrees, excludedIngredients);
                AvailableEntrees = AvailableEntrees.Where(item =>
                {
                    foreach (string ingredient in excludedIngredients)
                    {
                        if (item.Ingredients.Contains(ingredient))
                        {
                            return false;
                        }
                    }

                    return true;
                });

                //AvailableSides = Menu.FilterByExcludedIngredients(AvailableSides, excludedIngredients);
                AvailableSides = AvailableSides.Where(item =>
                {
                    foreach (string ingredient in excludedIngredients)
                    {
                        if (item.Ingredients.Contains(ingredient))
                        {
                            return false;
                        }
                    }

                    return true;
                });

                //AvailableDrinks = Menu.FilterByExcludedIngredients(AvailableDrinks, excludedIngredients);
                AvailableDrinks = AvailableDrinks.Where(item =>
                {
                    foreach (string ingredient in excludedIngredients)
                    {
                        if (item.Ingredients.Contains(ingredient))
                        {
                            return false;
                        }
                    }

                    return true;
                });
            }
        }
    }
}