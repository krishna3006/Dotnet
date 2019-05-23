using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWebapps
{
    /// <summary>
    /// Interaction logic for Hello.xaml
    /// </summary>
    public partial class Hello : Page
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to wpfweb");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Go to lunch at 12.30 pm");
        }
        private void Button_Click_2(object sender,RoutedEventArgs e)
        {
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            Menupage nextPage = new Menupage();
            nav.Navigate(nextPage);
        }
    }
}
