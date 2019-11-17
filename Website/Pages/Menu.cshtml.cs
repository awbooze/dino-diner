/*  Menu.cshtml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public Menu Menu { get; private set; }

        /// <summary>
        /// Method executed whenever a get request is recieved to get the current page. 
        /// Creates a reference to the Menu object and assigns it to the Menu variable.
        /// </summary>
        public void OnGet()
        {
            Menu = new Menu();
        }
    }
}