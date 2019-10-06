﻿using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal.
    /// </summary>
    public class CretaceousCombo : MenuItem
    {
        // Private backing variables
        private Size size;

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; } = new Sodasaurus();

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; set; }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side { get; set; } = new Fryceritops();

        /// <summary>
        /// Gets the toy
        /// </summary>
        public string Toy { get; private set; }

        /// <summary>
        /// Gets a list of ingredients for the combo
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public override double Price
        {
            get
            {
                return Drink.Price + Entree.Price + Side.Price - 0.25;
            }
        }

        /// <summary>
        /// Get the calories of the combo.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return Drink.Calories + Entree.Calories + Side.Calories;
            }
        }

        /// <summary>       
        /// Gets or sets the size of the combo        
        /// </summary>        
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree.
        /// </summary>
        /// <param name="entree">The entree to use.</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Toy = "Dinosaur Toy";
        }
    }
}