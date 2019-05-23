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
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.BusinessLayer;
using Capgemini.EmployDetails.Exceptions;

namespace EmployApplicationWPF
{
    /// <summary>
    /// Interaction logic for EmployDelete.xaml
    /// </summary>
    public partial class EmployDelete : Window
    {
        public EmployDelete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int deleteEmployID = Convert.ToInt32(txtEmployID.Text);
            try
            {
                Employ deleteEmploy = EmployBL.SearchEmployBL(deleteEmployID);
                if (deleteEmploy != null)
                {
                    bool employDeleted = EmployBL.DeleteEmployBL(deleteEmployID);
                    if (employDeleted)
                    {
                        MessageBox.Show("Record Deleted...");
                    }
                }
                else 
                {
                    MessageBox.Show("Record not found to Delete...");
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
