﻿using System;
using System.Windows;


namespace RenumberParts
{
    public partial class Resources : ResourceDictionary
    {
      
        private void EngworksLink(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://engworks.com/");
        }

        private void AddInLink(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://engworks.com/");
        }
    }
}
