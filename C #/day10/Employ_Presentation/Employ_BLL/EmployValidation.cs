using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emp_Exceptions;
using EmpEntity;
using Emp_DAL;
using System.Text.RegularExpressions;

namespace Employ_BLL
{
    public class EmployValidation
    {
        static List<Employ> empList = new List<Employ>();
        EmployOperation operationObj;
        public void SerializeEmployeeBLL()
        {
            try
            {
                EmployOperation.SerializeEmployeeDAL();
            }
            catch (Exception ex) { throw ex; }
        }
        public List<Employ>DeserializeEmployeeBLL()
        {
            List<Employ> empList = null;
            try
            {
                empList = EmployOperation.DeSerializeEmployeeDAL();
                if (empList.Count <= 0) throw new EmployException("No records found");
            }
            catch (EmployException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            return empList;

        }
        public bool ValidateEmploy(Employ newEmploy)
        {
            bool isValidEmploy = true;
            StringBuilder sb = new StringBuilder();
            if (newEmploy.Empno <= 0)
            {
                isValidEmploy = false;
                sb.Append("employ to Cannot be zero or Negative" + Environment.NewLine);
            }
            if (newEmploy.Name.Length == 0)
            {
                isValidEmploy = false;
                sb.Append("Name cannot be empty.." + Environment.NewLine);
            }
            if (newEmploy.Doj >= DateTime.Now)
            {
                isValidEmploy = false;
                sb.Append("doj cannot be tomorrow's date.." + Environment.NewLine);
            }
            if (!(Regex.IsMatch(newEmploy.Mobile, "{0-9}{10}")))
            {
                isValidEmploy = false;
                sb.Append("employee mobile should have 10 digits" + Environment.NewLine);
            }
            if (!isValidEmploy)
            {
                throw new EmployException("validtion failed,E");
            }
            return isValidEmploy;
        }

        public bool AddEmployBLL(Employ newEmploy)
        {
            bool isEmpAdded = false;
            operationObj = new EmployOperation();
            if (ValidateEmploy(newEmploy))
            {
                isEmpAdded = operationObj.AddEmployDAL(newEmploy);
            }
            else
            {
                throw new EmployException("VAlidation failed!!! Employ Record could not be added");
            }
            return isEmpAdded;
        }
        public List<Employ> DisplayEmployBLL()
        {
            operationObj = new EmployOperation();
            empList = operationObj.DisplayEmployDAL();
            if (empList.Count <= 0)
            {
                throw new EmployException("No records found");
            }
            return empList;
        }
        public bool UpdateEmployBLL(Employ editEmploy)
        {
            operationObj = new EmployOperation();
            bool isUpdated = false;
            isUpdated = operationObj.UpdateEmployDAl(editEmploy);
            if (isUpdated == false)
            {
                throw new EmployException("Employ no not found");
            }
            return isUpdated;
        }
        public bool DeleteEmployBLL(int empno)
        {
            bool isDeleted = false;
            operationObj = new EmployOperation();
            isDeleted = operationObj.DeleteEmployDAL(empno);
            if (isDeleted == false)
            {
                throw new EmployException("Employ no not found...");
            }
            return isDeleted;

        }
        public Employ SearchEmployBLL(int empno)
        {
            operationObj = new EmployOperation();
            Employ searchEmploy = null;
            searchEmploy = operationObj.SearchEmployDAL(empno);
            if (searchEmploy == null)
            {
                throw new EmployException("employee not found");
            }
            return searchEmploy;
        }


    }
}
