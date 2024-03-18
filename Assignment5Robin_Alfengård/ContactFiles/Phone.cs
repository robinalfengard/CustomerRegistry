using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård.ContactFiles
{
    internal class Phone
    {
        private string phoneNumberHome;
        private string phoneNumberWork;


        public Phone(string phoneNumberHome, string phoneNumberWork)
        {
            this.phoneNumberHome = phoneNumberHome;
            this.phoneNumberWork = phoneNumberWork;
        }

        public string PhoneNumberHome
        {
            get { return phoneNumberHome; }
            set { phoneNumberHome = value; }

        }

        public string PhoneNumberWork
        {
            get { return phoneNumberWork; }
            set { phoneNumberWork = value; }

        }
    }
}
