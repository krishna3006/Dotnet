using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DAL.EmployServiceReference;
using EMS.DAL;
using System.Data.SqlClient;
using System.Data;

namespace EMS.BLL
{
    public class EmployBLL
    {
        public static bool ValidateEmploy(Employ e)
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (e.Empno <= 0 || e.Empno == 0)
            {
                result = false;
                sb.Append("Empno cannot be blank or negative");
            }

            if (e.Name == string.Empty)
            {
                result = false;
                sb.Append("Employ Name cannot be blank");
            }

            if (e.Desig == string.Empty)
            {
                result = false;
                sb.Append("Desig cannot be blank");
            }
            if (e.Dept == string.Empty)
            {
                result = false;
                sb.Append("Dept cannot be Empty");
            }
            if(e.Basic <= 0 || e.Basic == 0)
            {
                result = false;
                sb.Append("Salary cannot be empty");
            }
            if (result == false)
            {
                throw new EmployException.EmployException(sb.ToString());
            }
            return result;
        }
        public static string DeleteEmployBLL(int Empno)
        {
            string EmployDelete = string.Empty;

            try
            {
                if (Empno > 0)
                {
                    EmployDAL emsdal = new EmployDAL();
                    EmployDelete = emsdal.DeleteEmployDAL(Empno);
                }
                else
                {
                    throw new EmployException.EmployException("Invalid Employ no");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return EmployDelete;
        }
        public static bool UpdateEmployBLL(Employ e)
        {
            bool Employupdate = false;
            try
            {
                if (ValidateEmploy(e))
                {
                    EmployDAL emsdal = new EmployDAL();
                    Employupdate = emsdal.UpdateEmployDAL(e);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Employupdate;
        }
        public static bool AddEmployBLL(Employ e)
        {
            bool Employadded = false;
            try
            {
                EmployDAL obj = new EmployDAL();
                Employadded = obj.AddEmployDAL(e);
            }
            catch (Exception ex)
            {

                throw new EmployException.EmployException(ex.Message);
            }
            return Employadded;
        }
        public static Employ GetEmployBLL(int eEmpno)
        {
            Employ e = null;
            try
            {
                EmployDAL bmsdal = new EmployDAL();
                e = bmsdal.GetEmployDAL(eEmpno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return e;
        }
        public static List<Employ> GetEmploysBLL()
        {
            List<Employ> elist = null;
            try
            {
                EmployDAL emsdal = new EmployDAL();
                elist = emsdal.GetEmploysDAL();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return elist;
        }
    }
}
