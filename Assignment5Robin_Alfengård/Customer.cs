using Assignment5Robin_Alfengård.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård
{
    internal class Customer
    {
        Contact contact;

        public Customer(Contact contact)
        {
            this.contact = contact;
        }

        public Customer() { }
        

        

        public Contact Contact
        {
            get
            { return contact; }
            set
            {
                contact = value;
            }
        }
    }
}
