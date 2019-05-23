using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capgemini.PatientDetails.Entities;
using Capgemini.PatientDetails.Exceptions;
using Capgemini.PatientDetails.DataAccessLayer;
namespace Capgemini.PatientDetails.BusinessLayer
{
    public class PatientBL
    {
        public static DataTable GetAllPatientBL()
        {
            DataTable dt = new DataTable();
            try
            {
                PatientDAL patientDAL = new PatientDAL();
                dt = patientDAL.GetAllPatientDAL();
            }
            catch (PatientException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                
                throw e;
            }
            return dt;
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

                throw e;
            }
            return patientAdded;
        }
    }
}
