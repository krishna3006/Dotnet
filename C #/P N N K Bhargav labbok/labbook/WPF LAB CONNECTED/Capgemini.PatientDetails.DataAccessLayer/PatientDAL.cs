using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capgemini.PatientDetails.Entities;
using Capgemini.PatientDetails.Exceptions;
namespace Capgemini.PatientDetails.DataAccessLayer
{
    public class PatientDAL
    {
        SqlConnection cnsql;
        SqlCommand cmd;
        public DataTable GetAllPatientDAL()
        {
            DataTable dt;
            try
            {
                string strcon = "integrated security=true;initial catalog=sqlpractice;data source=DESKTOP-AKGKCCF";
                cnsql = new SqlConnection(strcon);
                cnsql.Open();
                cmd = new SqlCommand("prcGetAllPatient", cnsql);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                 dt = new DataTable();
                dt.Load(dr);
             

            }
            catch (Exception e)
            {

                throw new PatientException(e.Message);
            }
            finally
            {
                cnsql.Close();
            }
            return dt;

        }
        public bool AddPatientDAL(Patient p)
        {
            bool isAdded;
            try
            {
                string strcon = "integrated security=true;initial catalog=sqlpractice;data source=DESKTOP-AKGKCCF";
                cnsql = new SqlConnection(strcon);
                cnsql.Open();
                cmd = new SqlCommand("prcAddPAtient", cnsql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", p.PatientID);
                cmd.Parameters.AddWithValue("@name", p.PatientName);
                cmd.Parameters.AddWithValue("@type", p.PatientType);
                cmd.ExecuteNonQuery();
                isAdded = true;
            }
            catch (Exception e)
            {

                throw new PatientException(e.Message);
            }
            finally
            {
                cnsql.Close();
            }
            return isAdded;

        }
    }
}