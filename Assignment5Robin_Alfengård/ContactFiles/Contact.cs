using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård.ContactFiles
{
    internal class Contact
    {
        private Address address;
        private Email email;
        private Phone phone;
        private string firstName;
        private string lastName;


        public Contact(Address address, Email email, Phone phone, string firstName, string lastName)
        {
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Contact ()
        {

        }

        public Address Address {
            get {  return address; }
            set { address = value;  } 
        }

        public Email Email
        {
            get { return email; }
            set { email = value; }
        }

        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


    }
}
