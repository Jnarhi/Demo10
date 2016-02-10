using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace D10T1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            string Products = "";
            // myCheckBox is checked
            if ((bool)milkCheckBox.IsChecked)
            {
                Products += "Milk ";
            }
            // myCheckBox is checked
            if ((bool)butterCheckBox.IsChecked)
            {
                Products += "Butter ";
            }
            // myCheckBox is checked
            if ((bool)beerCheckBox.IsChecked)
            {
                Products += "Beer ";
            }
            // myCheckBox is checked
            if ((bool)chickenCheckBox.IsChecked)
            {
                Products += "Chicken ";
            }
            // myCheckBox is checked
            if ((bool)lemonadeCheckBox.IsChecked)
            {
                Products += "Lemonade ";
            }

            shoppingBox.Text = Products.ToString();
        }
    }
}
