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
    public partial class ContactForm : Form
    {
        private CustomerManager customerManager;
        private Customer tempCustomer;
        private bool IsInEditMode = false;

        // Constructor - add
        public ContactForm(CustomerManager customerManager)
        {
            InitializeComponent();
            countrySelectionAdd.DataSource = Enum.GetValues(typeof(Country));
            this.customerManager = customerManager;
        }

        // Constructor - edit
        public ContactForm(CustomerManager customerManager, Customer customer)
        {
            InitializeComponent();
            countrySelectionAdd.DataSource = Enum.GetValues(typeof(Country));
            this.customerManager = customerManager;
            this.tempCustomer = customer;
            IsInEditMode = true;
            SetFields(customer);
        }


        // Method to allow user to add/edit customer
        private void OKButtonClick(object sender, EventArgs e)
        {
            if (!IsInEditMode)
            {
                Contact contact = new Contact();
                Customer customer = new Customer();
                contact.FirstName = firstNameInputAdd.Text;
                contact.LastName = lastNameInputAdd.Text;
                Address address = new Address(streetInputAdd.Text, (Country)countrySelectionAdd.SelectedItem, zipCodeIpnutAdd.Text, cityInputAdd.Text);
                contact.Address = address;
                Phone phone = new Phone(homePhoneInputAdd.Text, cellPhoneInputAdd.Text);
                contact.Phone = phone;
                Email email = new Email(workMailInputAdd.Text, privateMailInputAdd.Text);
                contact.Email = email;
                customer.Contact = contact;
                if (contact.CheckData(firstNameInputAdd.Text, lastNameInputAdd.Text, cityInputAdd.Text))
                {
                    customerManager.AddCustomer(customer);
                    customer.Id = customerManager.GetIndexOfCustomer(customer);
                    ResetAllFields();
                }
                else
                {
                    MessageBox.Show("You Need to At Least Input\nFirstname/LastName\nCity\nCountry");
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                tempCustomer.Contact.FirstName = firstNameInputAdd.Text;
                tempCustomer.Contact.LastName = lastNameInputAdd.Text;
                tempCustomer.Contact.Email.Work = workMailInputAdd.Text;
                tempCustomer.Contact.Email.Personal = privateMailInputAdd.Text;
                tempCustomer.Contact.Phone.PhoneNumberHome = homePhoneInputAdd.Text;
                tempCustomer.Contact.Phone.PhoneNumberWork = cellPhoneInputAdd.Text;
                tempCustomer.Contact.Address.Street = streetInputAdd.Text;
                tempCustomer.Contact.Address.City = cityInputAdd.Text;
                tempCustomer.Contact.Address.ZipCode = zipCodeIpnutAdd.Text;
                tempCustomer.Contact.Address.Countries = (Country)countrySelectionAdd.SelectedItem;
                if (!tempCustomer.Contact.CheckData(firstNameInputAdd.Text, lastNameInputAdd.Text, cityInputAdd.Text))
                {
                    MessageBox.Show("You Need to At Least Input\nFirstname/LastName\nCity\nCountry");
                    this.DialogResult = DialogResult.None;
                }
            }
        }


        // Method to reset all input fields
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


        // Method to handle click on cancel button 
        private void CancelClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.",
                                      "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetAllFields();
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }


        // Method to set all fields before edit
        private void SetFields(Customer customer)
        {
            firstNameInputAdd.Text = customer.Contact.FirstName;
            lastNameInputAdd.Text = customer.Contact.LastName;
            homePhoneInputAdd.Text = customer.Contact.Phone.PhoneNumberHome;
            cellPhoneInputAdd.Text = customer.Contact.Phone.PhoneNumberWork;
            workMailInputAdd.Text = customer.Contact.Email.Work;
            privateMailInputAdd.Text = customer.Contact.Email.Personal;
            streetInputAdd.Text = customer.Contact.Address.Street;
            cityInputAdd.Text = customer.Contact.Address.City;
            zipCodeIpnutAdd.Text = customer.Contact.Address.ZipCode;
            countrySelectionAdd.Text = customer.Contact.Address.Countries.ToString();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
