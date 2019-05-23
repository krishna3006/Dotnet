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
    /// Interaction logic for Databind1.xaml
    /// </summary>
    public partial class Databind1 : Window
    {
        public Databind1()
        {
            InitializeComponent();
            this.DataContext = person;
        }
        Person person = new Person { Name = "Arun", Age = 22 };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + "is" + person.Age;
            MessageBox.Show(message);
        }
    }
}
