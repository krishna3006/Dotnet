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
using Capgemini.PatientDetails.Entities;
using Capgemini.PatientDetails.Exceptions;
using Capgemini.PatientDetails.DataAccessLayer;
using Capgemini.PatientDetails.BusinessLayer;
using System.Data;

namespace HospitalManagementPresentation
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
            patient.PatientID = Convert.ToInt32(txtPatientid.Text);
            patient.PatientName = txtPatientname.Text;
            patient.PatientType = cbPatienttype.Text;
            bool res = PatientBL.AddPatientBL(patient);
            MessageBox.Show("Patient Details Added Successfully");
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PatientBL.GetAllPatientBL();
            dgPatient.ItemsSource = dt.DefaultView;

        }
    }
}

