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
using Cagemini.HospitalDetails.DataAccessLayer;
using Capgemini.HospitalDetails.BusinessLayer;
using Capgemini.HospitalDetails.Entities;
using Capgemini.HospitalDetails.Exceptions;

namespace HospitalManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        int MaxAttempts = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientDetails obj = new PatientDetails();
           

            if (MaxAttempts < 3)
            {
                if (txtUsername.Text != "Administrator" || txtPassword.Password != "Administrator")
                {
                    MaxAttempts++;
                    MessageBox.Show("Incorrect Credientials");

                }

                if (txtUsername.Text == "Administrator" && txtPassword.Password == "Administrator")
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
