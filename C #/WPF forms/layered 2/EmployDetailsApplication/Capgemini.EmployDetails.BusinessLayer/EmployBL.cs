using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capgemini.EmployDetails.Exceptions;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.DataAccessLayer;
using System.Threading.Tasks;

namespace Capgemini.EmployDetails.BusinessLayer
{
    public class EmployBL
    {
        private static bool Validate(Employ employ)
        {
            StringBuilder sb = new StringBuilder();
            bool validateEmploy = true;
            if (employ.EmployName == string.Empty)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "EMploy name required");
            }
            if (employ.Salary < 1000)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "Salary cannot be less thatn 1000");
            }
            if (employ.Salary > 99999)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "Salary cannot cross 99999");
            }
            if (validateEmploy == false)
            {
                throw new EmployException(sb.ToString());
            }
            return validateEmploy;
        }
        public static List<Employ> GetALLEmployBL()
        {
            List<Employ> employList = null;
            EmployDAL employDAL = new EmployDAL();
            employList = employDAL.GetAllEmployDAL();
            return employList;
        }
        public static bool UpdateEmployBL(Employ employ)
        {
            bool employUpdated = false;
            try
            {
                if(Validate(employ))
                {
                EmployDAL employDAL = new EmployDAL();
                employUpdated = employDAL.UpdateEmployDAL(employ);
            }
         }
        catch(EmployException)
            {
            throw;
            }
            catch(Exception ex)
            {
             throw ex;
            }
             return employUpdated;
        }

        public static List<Employ> GetAllEmployBL()
        {
            throw new NotImplementedException();
        }

        public static bool DeleteEmployBL(int employID)
        {
            bool employDeleted = false;
            try
            {
                if (employID > 0)
                {
                    EmployDAL employDAL = new EmployDAL();
                    employDeleted = employDAL.DeleteEmployDAL(employID);
                }
                else
                {
                    throw new EmployException("Invalid Employ ID");
                }
            }
            catch (EmployException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return employDeleted;
        }
        public static Employ SearchEmploy(int searchEmployID)
        {
            Employ searchedEmploy = null;
            try
            {
                EmployDAL employDAL = new EmployDAL();
                searchedEmploy = employDAL.SearchEmployDAL(searchEmployID);
            }
            catch (EmployException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return searchedEmploy;
        }
        public static bool AddEmployBL(Employ employ)
        {
            bool employAdded = false;
            try
            {
                if (Validate(employ))
                {
                    EmployDAL employDAL = new EmployDAL();
                    employAdded = employDAL.AddEmployDAL(employ);
                }
            }
            catch (EmployException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return employAdded;

        }

        public static Employ SearchEmployBL(int searchEmployID)
        {
            throw new NotImplementedException();
        }
    }
}
