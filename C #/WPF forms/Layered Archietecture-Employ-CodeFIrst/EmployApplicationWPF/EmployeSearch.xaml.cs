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
using Capgemini.EmployDetails.BusinessLayer;
using Capgemini.EmployDetails.DataAccessLayer;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.Exceptions;


namespace EmployApplicationWPF
{
    /// <summary>
    /// Interaction logic for EmployeSearch.xaml
    /// </summary>
    public partial class EmployeSearch : Window
    {
        public EmployeSearch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int searchEmployID = Convert.ToInt32(txtEmployID.Text);
            try
            {
                Employ searchEmploy = EmployBL.SearchEmployBL(searchEmployID);
                if (searchEmploy != null)
                {
                    txtEmployName.Text = searchEmploy.EmployName;
                    txtSalary.Text = searchEmploy.Salary.ToString();
                    txtDept.Text = searchEmploy.Department;
                }
            }
            catch (EmployException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
