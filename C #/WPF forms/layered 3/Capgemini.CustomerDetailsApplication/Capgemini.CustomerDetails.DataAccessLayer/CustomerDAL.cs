using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.CustomerDetails.Entities;
using Capgemini.CustomerDetails.Exceptions;

namespace Capgemini.CustomerDetails.DataAccessLayer
{
    public class CustomerDAL
    {
        CustomerContext context = new CustomerContext();

        public List<Customer> GetAllCustomerDAL()
        {
            List<Customer> customerList = null;
            try
            {
                customerList = context.Customers.ToList();
            }
            catch (Exception ex)
            {

                throw new CustomerException(ex.Message);
            }
            return customerList;
        }

        public bool DeleteCustomerDAL(int custID)
        {
            bool customerDeleted = false;
            try
            {
                Customer customer = null;
                customer = context.Customers.Where(e => e.CustID == custID).Select(e => e).FirstOrDefault();
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    int status = context.SaveChanges();
                    if (status > 0)
                    {
                        customerDeleted = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new CustomerException(ex.Message);
            }
            return customerDeleted;
        }

        public bool UpdateCustomerDAL(Customer customer)
        {
            bool customerupdated = false;
            try
            {
                Customer oldCustomer = null;
                oldCustomer = context.Customers.Where(e => e.CustID == customer.CustID).Select(e => e).FirstOrDefault();
                if (oldCustomer != null)
                {
                    oldCustomer.CustName = customer.CustName;
                    oldCustomer.Dob = customer.Dob;
                    oldCustomer.City = customer.City;
                    oldCustomer.BillAmount = customer.BillAmount;

                    int status = context.SaveChanges();
                    if (status > 0)
                    {
                        customerupdated = true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new CustomerException(ex.Message);
            }
            return customerupdated;
        }

        public Customer SearchCustomerDAL(int custID)
        {
            Customer searchedCustomer = null;
            try
            {
                searchedCustomer = context.Customers.Where(e =>
                    e.CustID == custID).Select(e => e).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new CustomerException(ex.Message);
            }
            return searchedCustomer;
        }

        public bool AddCustomerDAL(Customer customer)
        {
            bool customerAdded = false;
            try
            {
                context.Customers.Add(customer);

                int status = context.SaveChanges();

                if (status > 0)
                {
                    customerAdded = true;
                }
            }
            catch (Exception ex)
            {

                throw new CustomerException(ex.Message);
            }
            return customerAdded;
        }

    }
}