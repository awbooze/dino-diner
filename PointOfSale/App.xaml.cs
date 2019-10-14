/*  App.xaml.cs
*   Author: Andrew Booze
*/

using System.Windows;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Creates a string that is a valid id or name for a UIElement by removing all spaces, dashes, 
        /// and "&" symbols.
        /// </summary>
        /// <param name="id">The id string to transform.</param>
        /// <returns>A valid id string for a UIElement.</returns>
        public static string CreateValidIdString(string id)
        {
            return id.Replace(' ', '_').Replace('-', '_').Replace('&', '_');
        }

        /// <summary>
        /// Removes the "Small" from the string returned by Drink or Side ToString methods.
        /// </summary>
        /// <param name="name">A string with "Small" in it.</param>
        /// <returns>The same string without the "Small" in-front of it.</returns>
        public static string CorrectDrinkAndSideNames(string name)
        {
            return name.Replace("Small ", "");
        }
    }
}
