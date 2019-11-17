using DinoDiner.Menu;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public List<CretaceousCombo> ComboList { get; private set; }

        public List<Entree> EntreeList { get; private set; }

        public List<Side> SideList { get; private set; }

        public List<Drink> DrinkList { get; private set; }

        public void OnGet()
        {
            Menu menu = new Menu();
            ComboList = menu.AvailableCombos;
            EntreeList = menu.AvailableEntrees;
            SideList = menu.AvailableSides;
            DrinkList = menu.AvailableDrinks;
        }
    }
}