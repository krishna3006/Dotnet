using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpEntity;
using Emp_Exceptions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Emp_DAL
{
    public class EmployOperation
    {
        static List<Employ> employList = new List<Employ>();

        public static object BinFormatter { get; private set; }

        public static void SerializeEmployeeDAL()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("Exam.txt", FileMode.Create, FileAccess.Write);
                BinaryFormatter binf = new BinaryFormatter();
                binf.Serialize(fs, employList);
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                fs.Close();
            }
        }
        public static List<Employ> DeSerializeEmployeeDAL()
        {
            List<Employ> deserializedData = null;
            FileStream fStream = null;
            try
            {
                try
                {
                    fStream = new FileStream("Exam.txt", FileMode.Open, FileAccess.Read);
                    BinaryFormatter binformatter = new BinaryFormatter();
                    deserializedData = (List<Employ>)BinFormatter.Deserialize(fStream);

                }
                catch (Exception)
                {

                    throw;

                }
                finally
                {
                    fStream.Close();
                }
                return deserializedData;

            
            }
    }
        
        public bool AddEmployDAL(Employ newEmploy)
        {
            bool isEmpAdded = false;
            try
            {
                employList.Add(newEmploy);
                isEmpAdded = true;
            }
            catch (EmployException)
            {

                throw;
            }
            return isEmpAdded;
        }
        public bool UpdateEmployDAl(Employ editEmploy)
        {
            Employ updateEmploy;
            bool isEmployUpdate = false;
            updateEmploy = SearchEmployDAL(editEmploy.Empno);
            if (updateEmploy != null)
            {
                isEmployUpdate = true;
                updateEmploy.Name = editEmploy.Name;
                updateEmploy.Dept = editEmploy.Dept;
                updateEmploy.Desig = editEmploy.Desig;
                updateEmploy.Salary = editEmploy.Salary;
                updateEmploy.Doj = editEmploy.Doj;
                updateEmploy.Gender = editEmploy.Gender;
                updateEmploy.Mobile = editEmploy.Mobile;
            }
            else
            {
                throw new EmployException("Invalid EmployeeId.");
            }
            return isEmployUpdate;
        }


        public List<Employ> DisplayEmployDAL()
        {
            List<Employ> elist;
            try
            {
                elist = employList;
            }
            catch (EmployException)
            {

                throw;
            }
            return elist;
        }
        public bool DeleteEmployDAL(int empno)
        {
            bool isDeleted = false;
            try
            {
                Employ empDelete = SearchEmployDAL(empno);
                if (empDelete != null)
                {
                    isDeleted = true;
                    employList.Remove(empDelete);
                }
            }
            catch (EmployException)
            {

                throw;
            }
            return isDeleted;
        }
        public Employ SearchEmployDAL(int empno)
        {
            Employ searchEmploy = null;
            try
            {
                foreach (Employ e in employList)
                {
                    if (e.Empno == empno)
                    {
                        searchEmploy = e;
                    }
                }
            }
            catch (EmployException)
            {

                throw;
            }
            return searchEmploy;

        }
    }
























    }