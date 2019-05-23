using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DAL.EmployServiceReference;

namespace EMS.DAL
{
    public class EmployDAL
    {
        EmployServiceClient client = new EmployServiceClient();
        public string DeleteEmployDAL(int Empno)
        {
            string EmployDeleted = string.Empty;
            try
            {
                EmployDeleted = client.DeleteEmploy(Empno);
            }
            catch (Exception ex)
            {

                throw new EmployException.EmployException(ex.Message);
            }
            return EmployDeleted;
        }
        public bool UpdateEmployDAL(Employ e)
        {
            bool UpdatedEmploy = false;
            try
            {
                UpdatedEmploy = client.UpdateEmploy(e);
            }
            catch (Exception ex)
            {

                throw new EmployException.EmployException(ex.Message);
            }
            return UpdatedEmploy;
        }
        public bool AddEmployDAL(Employ e)
        {
            bool EmployAdded = false;
            try
            {
                EmployAdded = client.AddEmploy(e);
            }
            catch (Exception ex)
            {

                throw new EmployException.EmployException(ex.Message);
            }
            return EmployAdded;
        }
        public Employ GetEmployDAL(int Empno)
        {
            Employ e = null;
            try
            {
                e = client.SearchEmploy(Empno);
            }
            catch (Exception ex)
            {

                throw new EmployException.EmployException(ex.Message);
            }
            return e;
        }
        public List<Employ> GetEmploysDAL()
        {
            List<Employ> elist = null;
            try
            {
                elist = client.ShowEmploy().ToList();
            }
            catch (Exception ex)
            {

                throw new EmployException.EmployException(ex.Message);
            }
            return elist;
        }
    }
}
