using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capgemini.PatientDetails.Entities;
using Capgemini.PatientDetails.Exceptions;


namespace Capgemini.ProductDetails.BusinesLayer
{
    public class PatientBL
    {
        public static DataSet GetAllPatientBL()
        {
            DataSet dataset;
            try
            {
                PatientDAL patientDAL = new PatientDAL();
                dataset = patientDAL.GetAllPatientDAL();
            }
            catch (Exception e)
            {

                throw e;
            }
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

                throw e;
            }
            return patientAdded;
        }
    }
}
