using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PatientDetails.Entity;
using PatientDetails.Exceptions;
using PatientDetails.DataAccessLayer;

namespace PatientDetail.BusinessLayer
{
    public class PatientBL
    {
        public static DataSet GetAllPatientBL()
        {
            DataSet dataset;
            PatientDAL patientDAL = new PatientDAL();
            dataset = patientDAL.GetAllPatientDAL();
            return dataset;
        }
        public static bool AddPatientBL(Patient patient)
        {
            bool patientAdded = false;
            try
            {
                PatientDAL patientDAL = new PatientDAL();
                patientAdded = patientDAL.AddPatientDAL(patient);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            return patientAdded;
        }
    }
}
