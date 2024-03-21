using Assignment5Robin_Alfengård.ContactFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5Robin_Alfengård
{
    public partial class AddForm : Form
    {

        private InputValidator validator;
        private CustomerManager customerManager;
        private OverViewForm overViewForm;
        public AddForm(CustomerManager customerManager, OverViewForm overViewForm)
        {
            InitializeComponent();
            countrySelectionAdd.DataSource = Enum.GetValues(typeof(Country));
            validator = new InputValidator();
            this.customerManager = customerManager;
            this.overViewForm = overViewForm;
        }


        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomer(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            Customer customer = new Customer();

            if (validator.ValidateName(firstNameInputAdd.Text, lastNameInputAdd.Text))
            {
                contact.FirstName = firstNameInputAdd.Text;
                contact.LastName = lastNameInputAdd.Text;
            }


            if (validator.ValidateAdresses(streetInputAdd.Text, cityInputAdd.Text, zipCodeIpnutAdd.Text))
            {
                Address address = new Address(streetInputAdd.Text, cityInputAdd.Text, zipCodeIpnutAdd.Text, (Country)countrySelectionAdd.SelectedItem);
                contact.Address = address;
            }


            if (validator.ValidatePhoneNumbers(homePhoneInputAdd.Text, cellPhoneInput.Text))
            {
                Phone phone = new Phone(homePhoneInputAdd.Text, cellPhoneInputAdd.Text);
                contact.Phone = phone;
            }

            if (validator.ValidateEmailAdresses(privateMailInputAdd.Text, workMailInputAdd.Text))
            {
                Email email = new Email(workMailInputAdd.Text, privateMailInputAdd.Text);
                contact.Email = email;
            }


            if (validator.isValidContact(contact))
            {
                customer.Contact = contact;
                customerManager.addCustomer(customer);
                ResetAllFields();
                overViewForm.UpdateListOfCustomers();
            }



        }
        private void ResetAllFields()
        {
            firstNameInputAdd.Text = "";
            lastNameInputAdd.Text = "";
            streetInputAdd.Text = "";
            cityInputAdd.Text = "";
            zipCodeIpnutAdd.Text = "";
            privateMailInputAdd.Text = "";
            workMailInputAdd.Text = "";
            homePhoneInputAdd.Text = "";
            cellPhoneInputAdd.Text = "";
            countrySelectionAdd.SelectedItem = 0;
        }

        private void CancelAddClick(object sender, EventArgs e)
        {
            ResetAllFields ();
        }
    }
}
