using Assignment5Robin_Alfengård.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård
{
    public class Customer
    {
        private Contact contact;

        private long id = 0;

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
        public long Id
        {
            get
            { return id; }
            set
            {
                id = value;
            }
        }
    }
}
