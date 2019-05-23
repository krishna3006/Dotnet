using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.HospitalDetails.Entities;
using Capgemini.HospitalDetails.Exceptions;
using Cagemini.HospitalDetails.DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace Capgemini.HospitalDetails.BusinessLayer
{
    public class PatientBL
    {
        public static DataSet GetAllPatientBL()
        {
            DataSet dataset = new DataSet();
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
            catch (PatientException)
            {

                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return patientAdded;
        }
    }
}
