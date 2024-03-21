namespace Assignment5Robin_Alfengård
{
    public partial class OverViewForm : Form
    {

        private CustomerManager customerManager = new CustomerManager();
        private int INDEXADJUSTER = -1;
        public OverViewForm()
        {
            InitializeComponent();
            UpdateListOfCustomers();

        }

        // Method to register click on add button and open add form
        private void LoadAddCustomerFormClick(object sender, EventArgs e)
        {
            ContactForm addForm = new ContactForm(customerManager);
            if (addForm.ShowDialog() == DialogResult.OK)
                UpdateListOfCustomers(); 
        }


        // Method to update list of customers
        public void UpdateListOfCustomers()
        {
            listviewContactInfo.Items.Clear();
            foreach (var customer in customerManager.getCustomerList())
            {
                if (customer != null)
                {
                    listviewContactInfo.Items.Add(StringToBeAddedinListBox((customer.Id + 1).ToString(),
                                                                            customer.Contact.LastName,
                                                                            customer.Contact.FirstName,
                                                                            customer.Contact.Phone.PhoneNumberWork,
                                                                            customer.Contact.Email.Work));
                }
            }
        }

        // Method to register click on customer in list and send captured customer on to ShowExpandedCustomerInfo method
        private void ShowExpandedCustomerInfoOnClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listviewContactInfo.SelectedItems[0];
            string index = selectedItem.Text.Substring(0, 9).Trim();
            int numericIndex = -1;
            int.TryParse(index, out numericIndex);

            if (numericIndex != -1)
                ShowExpandedCustomerInfo(customerManager.GetCustomerById(numericIndex + INDEXADJUSTER));

        }

        // Method to show expanded info of customer when selected in list
        private void ShowExpandedCustomerInfo(Customer? customer)
        {
            ExpandedCustomerInfoTextBox.Clear();

            if (customer != null)
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
            }
            else
            {
                MessageBox.Show("Customer is null");
            }
        }

        // Method to register click on delete button and send captured customer on to delete method 
        private void DeleteCustomerClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = null;
            if (listviewContactInfo.SelectedItems.Count > 0)
            {
                selectedItem = listviewContactInfo.SelectedItems[0];
                string index = selectedItem.Text.Substring(0, 9).Trim();
                int numericIndex = -1;
                int.TryParse(index, out numericIndex);
                if (numericIndex != -1)
                    customerManager.DeleteCustomerById(numericIndex + INDEXADJUSTER);
                UpdateListOfCustomers();
                ClearCustomerExpandedInfo();
            }
            else
            {
                MessageBox.Show("You Must Select a Customer to Delete");
            }

        }
        // Method to clear expanded info about customer
        private void ClearCustomerExpandedInfo()
        {
            ExpandedCustomerInfoTextBox.Clear();
        }
        
        // Method to register click on edit button and send captured customer on to edit method 
        private void EditCustomerClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = null;
            if (listviewContactInfo.SelectedItems.Count > 0)
            {
                Customer customerToEdit = null;
                selectedItem = listviewContactInfo.SelectedItems[0];
                string index = selectedItem.Text.Substring(0, 9).Trim();
                int idOfCustomer = -1;
                int.TryParse(index, out idOfCustomer);
                if (idOfCustomer != -1)
                {
                    ContactForm editForm = new ContactForm(customerManager, customerManager.GetCustomerById(idOfCustomer + INDEXADJUSTER));
                    if (editForm.ShowDialog() == DialogResult.OK)
                        UpdateListOfCustomers();
                }
            }
            else
            {
                MessageBox.Show("You Must Select a Customer to Edit");
            }
        }

         //Format helper method
        private string StringToBeAddedinListBox(string indexOfCustomer, string lastName, string firstName, string officePhone, string officeEmail)
        {
            return String.Format("{0,-30} {1,-43} {2,30} {3, 45}  ", indexOfCustomer, lastName + ", " + firstName, officePhone, officeEmail);
        }

        private void OverViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
