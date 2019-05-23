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
using Capgemini.HospitalDetails.Entities;
using Capgemini.HospitalDetails.Exceptions;
using Capgemini.HospitalDetails.BusinessLayer;
using System.Data;
using System.Data.SqlClient;

namespace HospitalManagementSystemWPF
{
    /// <summary>
    /// Interaction logic for PatientDetails.xaml
    /// </summary>
    public partial class PatientDetails : Window
    {
        string strcon = "integrated security=true;initial catalog=sqlpractice; data source=DESKTOP-PQ5O1JP";
        SqlConnection cnSqlpractice;
        SqlCommand cmdMax;
        public PatientDetails()
        {
            InitializeComponent();
            cbPatienttype.Items.Add("InPatient");
            cbPatienttype.Items.Add("OutPatient");
            
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strMax = "SELECT MAX(PatientID) FROM PatientDetail";
            cmdMax = new SqlCommand(strMax, cnSqlpractice);
            int pid = Convert.ToInt32(cmdMax.ExecuteScalar());
            pid++;
            txtPatientid.Text = pid.ToString();
            cnSqlpractice.Close();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataSet patientDetails = new DataSet();
            patientDetails = PatientBL.GetAllPatientBL();
            DataTable dt = patientDetails.Tables[0];
            dgPatient.ItemsSource = dt.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();
            patient.PatientID = Convert.ToInt32(txtPatientid.Text);
            patient.PatientName = txtPatientname.Text;
            patient.PatientType = cbPatienttype.Text;
            bool res = PatientBL.AddPatientBL(patient);
            MessageBox.Show("Patient Details Added Successfully");
            txtPatientid.Clear();
            txtPatientname.Clear();
        }

        private void DgPatient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
