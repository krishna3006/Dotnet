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
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Firstno.Text);
            b = Convert.ToInt32(Secondno.Text);
            c = a + b;
            Result.Text = c.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Firstno.Text);
            b = Convert.ToInt32(Secondno.Text);
            c = a - b;
            Result.Text = c.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(Firstno.Text);
            b = Convert.ToInt32(Secondno.Text);
            c = a * b;
            Result.Text = c.ToString();
        }
    }
}
