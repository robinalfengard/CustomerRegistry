namespace Assignment5Robin_Alfengård
{
    public partial class OverViewForm : Form
    {
        public OverViewForm()
        {
            InitializeComponent();
        }

        private void LoadMainForm(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }
    }
}
