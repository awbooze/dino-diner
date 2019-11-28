/*  Menu.cshtml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Website.Pages
{
    /// <summary>
    /// The Model class for the Menu page.
    /// </summary>
    public class MenuModel : PageModel
    {
        public Menu Menu { get; private set; } = null;

        public List<CretaceousCombo> AvailableCombos { get; private set; } = null;

        public List<Entree> AvailableEntrees { get; private set; } = null;

        public List<Side> AvailableSides { get; private set; } = null;

        public List<Drink> AvailableDrinks { get; private set; } = null;

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
                AvailableCombos = Menu.Search(AvailableCombos, search);
                AvailableEntrees = Menu.Search(AvailableEntrees, search);
                AvailableSides = Menu.Search(AvailableSides, search);
                AvailableDrinks = Menu.Search(AvailableDrinks, search);
            }

            if (menuCategory.Count > 0)
            {
                
            }

            if (minimumPrice is float min)
            {
                AvailableCombos = Menu.FilterByMinimumPrice(AvailableCombos, min);
                AvailableEntrees = Menu.FilterByMinimumPrice(AvailableEntrees, min);
                AvailableSides = Menu.FilterByMinimumPrice(AvailableSides, min);
                AvailableDrinks = Menu.FilterByMinimumPrice(AvailableDrinks, min);
            }

            if (maximumPrice is float max)
            {
                AvailableCombos = Menu.FilterByMaximumPrice(AvailableCombos, max);
                AvailableEntrees = Menu.FilterByMaximumPrice(AvailableEntrees, max);
                AvailableSides = Menu.FilterByMaximumPrice(AvailableSides, max);
                AvailableDrinks = Menu.FilterByMaximumPrice(AvailableDrinks, max);
            }

            if (excludedIngredients.Count > 0)
            {

            }
        }
    }
}