using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public abstract class Entree
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public abstract List<string> Ingredients { get; }
    }
}
