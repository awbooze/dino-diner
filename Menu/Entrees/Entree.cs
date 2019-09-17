using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
    {
        public abstract double Price { get; set; }
        public abstract uint Calories { get; set; }
        public abstract List<string> Ingredients { get; }
    }
}
