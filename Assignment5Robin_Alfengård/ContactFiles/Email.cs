using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård.ContactFiles
{
    public class Email
    {
    
        private string personalMail;
      
        private string officeMail;


        public Email()
        {
        }

        public Email(string workMail) : this(workMail, string.Empty)
        {
        }

        public Email(Email theOther)
        {
            this.personalMail = theOther.personalMail;
            this.officeMail = theOther.officeMail;
        }

        public Email(string workMail, string personalMail)
        {
            officeMail = workMail;
            this.personalMail = personalMail;
        }

        public string Personal
        {
            //private mail
            get { return personalMail; }

            set { personalMail = value; }
        }


        public string Work
        {
            get { return officeMail; }

            set { officeMail = value; }
        }

    }
}
