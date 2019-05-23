using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.HospitalDetails.Entities;
using Capgemini.HospitalDetails.Exceptions;
using System.Data.SqlClient;
using System.Data;

namespace Cagemini.HospitalDetails.DataAccessLayer
{
    public class PatientDAL
    {
        string strcon = "integrated security=true;initial catalog=sqlpractice; data source=DESKTOP-PQ5O1JP";
        SqlConnection cnSqlpractice;
        SqlDataAdapter adapter;
        DataSet dataset;
        public DataSet GetAllPatientDAL()
        {
            try
            {
                cnSqlpractice = new SqlConnection(strcon);
                adapter = new SqlDataAdapter("SELECT * FROM PatientDetail", cnSqlpractice);
                dataset = new DataSet();
                adapter.Fill(dataset, "patientDummy");
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
            cnSqlpractice = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM PatientDetail", cnSqlpractice);
            dataset = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(dataset, "patientDummy");
            DataRow dr = dataset.Tables["patientDummy"].NewRow();
            dr["PatientID"] = patient.PatientID;
            dr["PatientName"] = patient.PatientName;
            dr["PatientType"] = patient.PatientType;
            dataset.Tables["patientDummy"].Rows.Add(dr);
            adapter.Update(dataset, "patientDummy");
            patientAdded = true;
            return patientAdded;
        }

    }
}
