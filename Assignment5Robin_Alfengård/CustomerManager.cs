using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård
{
    public class CustomerManager
    {
        private List<Customer> customerList;


        public CustomerManager()
        {
            customerList = new List<Customer>();    
        }   

        public void AddCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customerList.Remove(customer);
        }
        public List<Customer> getCustomerList()
        {
            return customerList;
        }

        public Customer GetCustomerById(int id)
        {      
           foreach (Customer customer in customerList)
            {
                if(customer.Id == id) return customer;
            }
            throw new ArgumentException("Customer not found");   
        }

        public int GetIndexOfCustomer(Customer customer)
        {
            return customerList.IndexOf(customer);
        }

        public void DeleteCustomerById(int id)
        {
            Customer customerToDelete = null;
            foreach(Customer customer in customerList)
            {
                if(customer.Id == id)
                    customerToDelete = customer;
            }
            customerList.Remove(customerToDelete);
        }


    }


}
