using Assignment5Robin_Alfengård.ContactFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5Robin_Alfengård
{
    public partial class EditForm : Form
    {
        private Customer tempCustomer;
        private InputValidator validator;
        private OverViewForm overViewForm;
        public EditForm(Customer customer, OverViewForm overViewForm)
        {
            tempCustomer = customer;
            InitializeComponent();
            countrySelectionEdit.DataSource = Enum.GetValues(typeof(Country));
            validator = new InputValidator();
            SetFields(tempCustomer);
            this.overViewForm = overViewForm;
        }

        private void SetFields(Customer customer)
        {
            firstNameInputEdit.Text = customer.Contact.FirstName;
            lastNameInputEdit.Text = customer.Contact.LastName;
            homePhoneInputEdit.Text = customer.Contact.Phone.PhoneNumberHome;
            cellPhoneInputEdit.Text = customer.Contact.Phone.PhoneNumberWork;
            workMailInputEdit.Text = customer.Contact.Email.Work;
            privateMailInputEdit.Text = customer.Contact.Email.Personal;
            streetInputEdit.Text = customer.Contact.Address.Street;
            cityInputEdit.Text = customer.Contact.Address.City;
            zipCodeIpnutEdit.Text = customer.Contact.Address.ZipCode;
            countrySelectionEdit.Text = customer.Contact.Address.Countries.ToString();
        }

        private void AcceptChangesClick(object sender, EventArgs e)
        {
            if (validator.ValidateName(firstNameInputEdit.Text, lastNameInputEdit.Text))
            {
                tempCustomer.Contact.FirstName = firstNameInputEdit.Text;
                tempCustomer.Contact.LastName = lastNameInputEdit.Text;
            }
            if (validator.ValidateEmailAdresses(privateMailInputEdit.Text, workMailInputEdit.Text))
            {
                tempCustomer.Contact.Email.Work = workMailInputEdit.Text;
                tempCustomer.Contact.Email.Personal = privateMailInputEdit.Text;
            }
            if (validator.ValidatePhoneNumbers(homePhoneInputEdit.Text, cellPhoneInputEdit.Text))
            {
                tempCustomer.Contact.Phone.PhoneNumberHome = homePhoneInputEdit.Text;
                tempCustomer.Contact.Phone.PhoneNumberWork = cellPhoneInputEdit.Text;
            }
            if (validator.ValidateAdresses(streetInputEdit.Text, cityInputEdit.Text, zipCodeIpnutEdit.Text))
            {

                tempCustomer.Contact.Address.Street = streetInputEdit.Text;
                tempCustomer.Contact.Address.City = cityInputEdit.Text;
                tempCustomer.Contact.Address.ZipCode = zipCodeIpnutEdit.Text;
            }
            tempCustomer.Contact.Address.Countries = (Country)countrySelectionEdit.SelectedItem;

            if (validator.isValidContact(tempCustomer.Contact))
            {
                overViewForm.UpdateListOfCustomers();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Updating Customer \nPlease Check Input Fields");
            }


        }

        private void CancelEditClick(object sender, EventArgs e)
        {
            SetFields(tempCustomer);
        }
    }
}
