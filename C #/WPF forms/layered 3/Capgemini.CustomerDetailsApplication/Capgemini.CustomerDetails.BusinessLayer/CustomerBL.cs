using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CustomerDetails.BusinessLayer
{
    public class CustomerBL
    {
        private static bool Validate(Customer customer)
        {
            StringBuilder sb = new StringBuilder();

            bool validateCustomer = true;

            if (customer.CustName == string.Empty)
            {
                validateCustomer = false;
                sb.Append(Environment.NewLine + "Customer Name Required");
            }
            if (customer.City == string.Empty)
            {
                validateCustomer = false;
                sb.Append(Environment.NewLine + "City is  Required");
            }
            if (customer.BillAmount < 500)
            {
                validateCustomer = false;
                sb.Append(Environment.NewLine + "Bill should be greater than 500");
            }

            if ((customer.Dob.Year - DateTime.Now.Year) < 10)
            {
                validateCustomer = false;
                sb.Append(Environment.NewLine + "Customer  should not be less than 10");
            }
            if (validateCustomer == false)
            {
                throw new CustomerException(sb.ToString());
            }
            return validateCustomer;
        }



        public static List<Customer> GetAllCustomerBL()
        {
            List<Customer> customerList = null;
            CustomerDAL customerDAL = new CustomerDAL();
            customerList = customerDAL.GetAllCustomerDAL();
            return customerList;

        }
        public static bool UpdateCustomerBL(Customer customer)
        {
            bool customerUpdated = false;

            try
            {
                if (Validate(customer))
                {
                    CustomerDAL customerDAL = new CustomerDAL();
                    customerUpdated = customerDAL.UpdateCustomerDAL(customer);
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerUpdated;
        }


        public static bool DeleteCustomerBL(int custID)
        {
            bool customerDeleted = false;

            try
            {
                if (custID > 0)
                {
                    CustomerDAL custmoerDAL = new CustomerDAL();
                    customerDeleted = custmoerDAL.DeleteCustomerDAL(custID);
                }
                else
                {
                    throw new CustomerException("Invalid Customer ID");
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerDeleted;
        }

        public static Customer SearchCustomerBL(int searchCustomerID)
        {
            Customer searchedCustomer = null;

            try
            {
                CustomerDAL customerDAL = new CustomerDAL();
                searchedCustomer = customerDAL.SearchCustomerDAL(searchCustomerID);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchedCustomer;
        }
        public static bool AddCustomerBL(Customer customer)
        {
            bool customerAdded = false;

            try
            {
                if (Validate(customer))
                {
                    CustomerDAL customerDAL = new CustomerDAL();
                    customerAdded = customerDAL.AddCustomerDAL(customer);
                }
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return customerAdded;
        }

    }
}

