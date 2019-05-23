using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployService.svc or EmployService.svc.cs at the Solution Explorer and start debugging.
    public class EmployService : IEmployService
    {
        static string strcon = ConfigurationManager.ConnectionStrings["empconn"].ConnectionString;
        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd;
        SqlDataReader dr;

        public bool AddEmploy(Employ e)
        {
            bool EmployAdded = false;

            try
            {
                cmd = new SqlCommand("prcEmpInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empno", e.Empno);
                cmd.Parameters.AddWithValue("@Name", e.Name);
                cmd.Parameters.AddWithValue("@Dept", e.Dept);
                cmd.Parameters.AddWithValue("@Desig", e.Desig);
                cmd.Parameters.AddWithValue("@Basic", e.Basic);
                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    EmployAdded = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return EmployAdded;
        }

        public bool UpdateEmploy(Employ e)
        {
            bool EmployUpdated = false;
            try
            {
                cmd = new SqlCommand("prcEmpUpdate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empno", e.Empno);
                cmd.Parameters.AddWithValue("@Nam", e.Name);
                cmd.Parameters.AddWithValue("@Dept", e.Dept);
                cmd.Parameters.AddWithValue("@Desig", e.Desig);
                cmd.Parameters.AddWithValue("@Basic", e.Basic);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    EmployUpdated = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return EmployUpdated;
        }
        public string DeleteEmploy(int Empno)
        {
            string procResult = string.Empty;

            try
            {
                conn.Open();
                cmd = new SqlCommand("prcEmpDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empno", Empno);
                cmd.Parameters.Add(new SqlParameter("@result", SqlDbType.VarChar, 30));
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                procResult = Convert.ToString(cmd.Parameters["@result"].Value);
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return procResult;
        }
        public Employ SearchEmploy(int Empno)
        {
            Employ e = null;
            try
            {
                cmd = new SqlCommand("prcEmpSearch", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empno", Empno);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    e = new Employ();
                    e.Empno = Convert.ToInt32(dr["Empno"]);
                    e.Name = Convert.ToString(dr["nam"]);
                    e.Dept = Convert.ToString(dr["dept"]);
                    e.Desig = Convert.ToString(dr["desig"]);
                    e.Basic = Convert.ToInt32(dr["basic"]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return e;
        }

        public List<Employ> ShowEmploy()
        {
            List<Employ> elist = null;
            try
            {
                cmd = new SqlCommand("prcEmpShow", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    elist = new List<Employ>();
                    while (dr.Read())
                    {
                        Employ e = new Employ();
                        e.Empno = Convert.ToInt32(dr["Empno"]);
                        e.Name = Convert.ToString(dr["nam"]);
                        e.Dept = Convert.ToString(dr["dept"]);
                        e.Desig = Convert.ToString(dr["desig"]);
                        e.Basic = Convert.ToInt32(dr["basic"]);
                        elist.Add(e);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return elist;
        }
    }
}
