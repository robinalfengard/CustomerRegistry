using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård
{
    internal class CustomerManager
    {
        private List<Customer> customerList;


        public CustomerManager()
        {
            customerList = new List<Customer>();    
        }   

        public void addCustomer(Customer customer)
        {
            customerList.Add(customer);
        }

        public void removeCustomer(Customer customer)
        {
            customerList.Remove(customer);
        }
        public List<Customer> getCustomerList()
        {
            return customerList;
        }

        public Customer getCustomerByIndex(int id)
        {
            return customerList[id];
        }



    }


}
