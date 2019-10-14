﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string CreateValidIdString(string id)
        {
            return id.Replace(' ', '_').Replace('-', '_').Replace('&', '_');
        }

        public static string CorrectDrinkAndSideNames(string name)
        {
            return name.Replace("Small ", "");
        }
    }
}
