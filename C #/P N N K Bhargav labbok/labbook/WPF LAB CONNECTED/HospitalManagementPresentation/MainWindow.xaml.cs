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
using System.Data;

namespace HospitalManagementPresentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int MaxAttempts = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientDetails obj = new PatientDetails();          
            if (MaxAttempts < 3)
            {
                if (txtUsername.Text != "admin" || txtPassword.Password != "admin")
                {
                    MaxAttempts++;
                    MessageBox.Show("Incorrect Credientials");

                }

                if (txtUsername.Text == "admin" && txtPassword.Password == "admin")
                {
                    MaxAttempts = 0;
                    MessageBox.Show("Login Successfull");                 
                    obj.Show();
                }
            }
            else
            {
                this.Close();
            }

        }
    }
}
