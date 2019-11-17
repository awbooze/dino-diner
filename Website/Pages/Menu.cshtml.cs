using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; private set; }

        public void OnGet()
        {
            Menu = new Menu();
        }
    }
}