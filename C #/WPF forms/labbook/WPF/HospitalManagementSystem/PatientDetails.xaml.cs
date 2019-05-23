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
using PatientDetails.Entity;
using PatientDetails.DataAccessLayer;
using PatientDetails.Exceptions;
using PatientDetail.BusinessLayer;
using System.Data.SqlClient;
using System.Data;

namespace HospitalManagementSystem
{
    /// <summary>
    /// Interaction logic for PatientDetails.xaml
    /// </summary>
    public partial class PatientDetails : Window
    {
        public PatientDetails()
        {
            InitializeComponent();
            cbPatienttype.Items.Add("InPatient");
            cbPatienttype.Items.Add("OutPatient");

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();
            patient.PatientID =Convert.ToInt32(txtPatientid.Text);
            patient.PatientName = txtPatientname.Text;
            patient.PatientType = cbPatienttype.Text;
            bool res = PatientBL.AddPatientBL(patient);
            MessageBox.Show("Patient Details Added Successfully");
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataSet patientDetails = PatientBL.GetAllPatientBL();

            DataTable dt = patientDetails.Tables[0];
            dgPatient.ItemsSource = dt.DefaultView;

        }
    }
}
