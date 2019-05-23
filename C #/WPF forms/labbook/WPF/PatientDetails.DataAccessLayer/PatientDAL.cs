using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientDetails.Entity;
using PatientDetails.Exceptions;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PatientDetails.DataAccessLayer
{
    public class PatientDAL
    {
        string strcon = "integrated security=true;initial catalog=sqlpractice;data source=TAMIZH";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataset;
        public DataSet GetAllPatientDAL()
        {
            try
            {
                connection = new SqlConnection(strcon);
                adapter = new SqlDataAdapter("SELECT * FROM PATIENTDETAIL", connection);
                dataset = new DataSet();
                adapter.Fill(dataset, "PATIENTDUMMY");
                return dataset;
            }
            catch (PatientException e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool AddPatientDAL(Patient patient)
        {
            bool patientAdded = false;
            connection = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM PATIENTDETAIL", connection);
            dataset = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(dataset, "PATIENTDUMMY");
            DataRow dr = dataset.Tables["PATIENTDUMMY"].NewRow();
            dr["PatientID"] = patient.PatientID;
            dr["PatientName"] = patient.PatientName;
            dr["PatientType"] = patient.PatientType;
            dataset.Tables["PATIENTDUMMY"].Rows.Add(dr);
            adapter.Update(dataset, "PATIENTDUMMY");
            patientAdded = true;
            return patientAdded;
        }
    }
}
