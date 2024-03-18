using Assignment5Robin_Alfengård.ContactFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5Robin_Alfengård
{
    public class InputValidator
    {
        public InputValidator() { }


        public bool ValidateAdresses(string street, string city, string zip)
        {
            if (String.IsNullOrEmpty(street) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(zip))
            {
                MessageBox.Show("Error In Adress Fields \nFields Can Not Be Empty");
                return false;
            }          
            return true;
        }

        public bool ValidateName(string firstName, string lastName)
        {
            if(String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Error In Name Fields\nFields Can Not Be Empty");
                return false;
            }

            return true; 
        }

        internal bool ValidateEmailAdresses(string privateEmail, string workEmail)
        {
            if (String.IsNullOrEmpty(privateEmail) || String.IsNullOrEmpty(workEmail))
            {
                MessageBox.Show("Error In E-Mail Fields\nFields Can Not Be Empty");
                return false;
            }

            return true;
        }

        internal bool ValidatePhoneNumbers(string homePhone, string cellPhone)
        {
            if (String.IsNullOrEmpty(homePhone) || String.IsNullOrEmpty(cellPhone))
            {
                MessageBox.Show("Error In Phone Fields\n Fields Can Not Be Empty");
                return false;
            }

            return true;
        }


        internal bool isValidContact(Contact contact)
        {
            if(contact.FirstName == null 
                || contact.LastName == null
                || contact.Email == null
                || contact.Address == null
                || contact.Phone == null) {
                return false;
            }
            return true;
        }
    }
}
