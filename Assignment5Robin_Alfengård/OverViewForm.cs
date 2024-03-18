namespace Assignment5Robin_Alfengård
{
    public partial class OverViewForm : Form
    {

        private CustomerManager customerManager = new CustomerManager();
        public OverViewForm()
        {
            InitializeComponent();
            UpdateListOfCustomers();
        }


        private void LoadAddCustomerFormClick(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(customerManager, this);
            addForm.ShowDialog();
        }

        public void UpdateListOfCustomers()
        {
            listviewContactInfo.Items.Clear();
            foreach (var customer in customerManager.getCustomerList())
            {
                if (customer != null)
                {
                    listviewContactInfo.Items.Add(StringToBeAddedinListBox(customerManager.getIndexOfCustomer(customer) + 1.ToString(),
                                                                            customer.Contact.LastName,
                                                                            customer.Contact.FirstName,
                                                                            customer.Contact.Phone.PhoneNumberWork,
                                                                            customer.Contact.Email.Work)); 
                }
            }
        }





        // Format helper method
        private string StringToBeAddedinListBox(string indexOfCustomer, string lastName, string firstName, string officePhone, string officeEmail)
        {
            return String.Format("{0,-30} {1,-43} {2,30} {3, 45}  ", indexOfCustomer, lastName + ", " + firstName, officePhone, officeEmail);
        }

        private void OverViewForm_Load(object sender, EventArgs e)
        {

        }

        private void listviewContactInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowExpandedCustomerInfoOnClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listviewContactInfo.SelectedItems[0];
            string index = selectedItem.Text.Substring(0, 9).Trim();
            int numericIndex = -1;
            int.TryParse(index, out numericIndex);

            if (numericIndex != -1)
                ShowExpandedCustomerInfo(customerManager.getCustomerByIndex(numericIndex - 1));
            
        }

        private void ShowExpandedCustomerInfo(Customer? customer)
        {
            ExpandedCustomerInfoTextBox.Clear();

            if(customer != null)
            {
                ExpandedCustomerInfoTextBox.Text =
                                                customer.Contact.FirstName + " " + customer.Contact.LastName + Environment.NewLine +
                                                customer.Contact.Address.City + Environment.NewLine +
                                                customer.Contact.Address.ZipCode + " " + customer.Contact.Address.City + Environment.NewLine +
                                                customer.Contact.Address.Countries + Environment.NewLine + Environment.NewLine +
                                                "Emails" + Environment.NewLine +
                                                "Private: " + customer.Contact.Email.Personal + Environment.NewLine +
                                                "Office: " + customer.Contact.Email.Work + Environment.NewLine +
                                                Environment.NewLine + "Phone Numbers" + Environment.NewLine +
                                                "Private: " + customer.Contact.Phone.PhoneNumberHome + Environment.NewLine +
                                                "Office: " + customer.Contact.Phone.PhoneNumberWork;
            } else
            {
                MessageBox.Show("Customer is null");            
            }
        }
    }
}
