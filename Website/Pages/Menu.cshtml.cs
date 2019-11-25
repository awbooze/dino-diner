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
        /// <summary>
        /// A reference to the Menu object created by the OnGet() method and set through the private setter.
        /// </summary>
        public Menu Menu { get; private set; } = new Menu();

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
            
        }

        /// <summary>
        /// Method executed whenever a post request is recieved for the current page. Searches and filters 
        /// the menu items on the page and then returns the ones that match the filters.
        /// </summary>
        public void OnPost()
        {
            
        }
    }
}