namespace Assignment5Robin_Alfengård
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameBoxAdd = new GroupBox();
            lastNameInputAdd = new TextBox();
            firstNameInputAdd = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            contactBoxAdd = new GroupBox();
            privateMailInputAdd = new TextBox();
            workMailInputAdd = new TextBox();
            mailPrivateLabel = new Label();
            mailWorkLAbel = new Label();
            cellPhoneInputAdd = new TextBox();
            homePhoneInputAdd = new TextBox();
            cellPhoneInput = new Label();
            homePhoneInput = new Label();
            addressBoxAdd = new GroupBox();
            countrySelectionAdd = new ComboBox();
            zipCodeIpnutAdd = new TextBox();
            countryAddLabel = new Label();
            zipCodeAddLabel = new Label();
            cityInputAdd = new TextBox();
            streetInputAdd = new TextBox();
            cityAddLabel = new Label();
            streetAddLabel = new Label();
            confrimAddButton = new Button();
            cancelAddButton = new Button();
            nameBoxAdd.SuspendLayout();
            contactBoxAdd.SuspendLayout();
            addressBoxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // nameBoxAdd
            // 
            nameBoxAdd.Controls.Add(lastNameInputAdd);
            nameBoxAdd.Controls.Add(firstNameInputAdd);
            nameBoxAdd.Controls.Add(lastNameLabel);
            nameBoxAdd.Controls.Add(firstNameLabel);
            nameBoxAdd.Location = new Point(70, 49);
            nameBoxAdd.Name = "nameBoxAdd";
            nameBoxAdd.Size = new Size(616, 161);
            nameBoxAdd.TabIndex = 1;
            nameBoxAdd.TabStop = false;
            nameBoxAdd.Text = "Name";
            // 
            // lastNameInputAdd
            // 
            lastNameInputAdd.BorderStyle = BorderStyle.FixedSingle;
            lastNameInputAdd.Location = new Point(189, 102);
            lastNameInputAdd.Name = "lastNameInputAdd";
            lastNameInputAdd.Size = new Size(319, 31);
            lastNameInputAdd.TabIndex = 5;
            // 
            // firstNameInputAdd
            // 
            firstNameInputAdd.BorderStyle = BorderStyle.FixedSingle;
            firstNameInputAdd.Location = new Point(189, 43);
            firstNameInputAdd.Name = "firstNameInputAdd";
            firstNameInputAdd.Size = new Size(319, 31);
            firstNameInputAdd.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(16, 102);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(95, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(14, 43);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(97, 25);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name";
            // 
            // contactBoxAdd
            // 
            contactBoxAdd.Controls.Add(privateMailInputAdd);
            contactBoxAdd.Controls.Add(workMailInputAdd);
            contactBoxAdd.Controls.Add(mailPrivateLabel);
            contactBoxAdd.Controls.Add(mailWorkLAbel);
            contactBoxAdd.Controls.Add(cellPhoneInputAdd);
            contactBoxAdd.Controls.Add(homePhoneInputAdd);
            contactBoxAdd.Controls.Add(cellPhoneInput);
            contactBoxAdd.Controls.Add(homePhoneInput);
            contactBoxAdd.Location = new Point(70, 234);
            contactBoxAdd.Name = "contactBoxAdd";
            contactBoxAdd.Size = new Size(616, 259);
            contactBoxAdd.TabIndex = 6;
            contactBoxAdd.TabStop = false;
            contactBoxAdd.Text = "Email and Phone";
            // 
            // privateMailInputAdd
            // 
            privateMailInputAdd.BorderStyle = BorderStyle.FixedSingle;
            privateMailInputAdd.Location = new Point(189, 198);
            privateMailInputAdd.Name = "privateMailInputAdd";
            privateMailInputAdd.Size = new Size(319, 31);
            privateMailInputAdd.TabIndex = 9;
            // 
            // workMailInputAdd
            // 
            workMailInputAdd.BorderStyle = BorderStyle.FixedSingle;
            workMailInputAdd.Location = new Point(189, 148);
            workMailInputAdd.Name = "workMailInputAdd";
            workMailInputAdd.Size = new Size(319, 31);
            workMailInputAdd.TabIndex = 8;
            // 
            // mailPrivateLabel
            // 
            mailPrivateLabel.AutoSize = true;
            mailPrivateLabel.Location = new Point(16, 198);
            mailPrivateLabel.Name = "mailPrivateLabel";
            mailPrivateLabel.Size = new Size(129, 25);
            mailPrivateLabel.TabIndex = 7;
            mailPrivateLabel.Text = "E-Mail (Private)";
            // 
            // mailWorkLAbel
            // 
            mailWorkLAbel.AutoSize = true;
            mailWorkLAbel.Location = new Point(14, 148);
            mailWorkLAbel.Name = "mailWorkLAbel";
            mailWorkLAbel.Size = new Size(118, 25);
            mailWorkLAbel.TabIndex = 6;
            mailWorkLAbel.Text = "E-Mail (Work)";
            // 
            // cellPhoneInputAdd
            // 
            cellPhoneInputAdd.BorderStyle = BorderStyle.FixedSingle;
            cellPhoneInputAdd.Location = new Point(189, 90);
            cellPhoneInputAdd.Name = "cellPhoneInputAdd";
            cellPhoneInputAdd.Size = new Size(319, 31);
            cellPhoneInputAdd.TabIndex = 5;
            // 
            // homePhoneInputAdd
            // 
            homePhoneInputAdd.BorderStyle = BorderStyle.FixedSingle;
            homePhoneInputAdd.Location = new Point(189, 43);
            homePhoneInputAdd.Name = "homePhoneInputAdd";
            homePhoneInputAdd.Size = new Size(319, 31);
            homePhoneInputAdd.TabIndex = 4;
            // 
            // cellPhoneInput
            // 
            cellPhoneInput.AutoSize = true;
            cellPhoneInput.Location = new Point(16, 90);
            cellPhoneInput.Name = "cellPhoneInput";
            cellPhoneInput.Size = new Size(95, 25);
            cellPhoneInput.TabIndex = 3;
            cellPhoneInput.Text = "Cell Phone";
            // 
            // homePhoneInput
            // 
            homePhoneInput.AutoSize = true;
            homePhoneInput.Location = new Point(14, 43);
            homePhoneInput.Name = "homePhoneInput";
            homePhoneInput.Size = new Size(116, 25);
            homePhoneInput.TabIndex = 2;
            homePhoneInput.Text = "Home Phone";
            // 
            // addressBoxAdd
            // 
            addressBoxAdd.Controls.Add(countrySelectionAdd);
            addressBoxAdd.Controls.Add(zipCodeIpnutAdd);
            addressBoxAdd.Controls.Add(countryAddLabel);
            addressBoxAdd.Controls.Add(zipCodeAddLabel);
            addressBoxAdd.Controls.Add(cityInputAdd);
            addressBoxAdd.Controls.Add(streetInputAdd);
            addressBoxAdd.Controls.Add(cityAddLabel);
            addressBoxAdd.Controls.Add(streetAddLabel);
            addressBoxAdd.Location = new Point(70, 515);
            addressBoxAdd.Name = "addressBoxAdd";
            addressBoxAdd.Size = new Size(616, 259);
            addressBoxAdd.TabIndex = 10;
            addressBoxAdd.TabStop = false;
            addressBoxAdd.Text = "Address";
            // 
            // countrySelectionAdd
            // 
            countrySelectionAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            countrySelectionAdd.FormattingEnabled = true;
            countrySelectionAdd.Location = new Point(189, 198);
            countrySelectionAdd.Name = "countrySelectionAdd";
            countrySelectionAdd.Size = new Size(319, 33);
            countrySelectionAdd.TabIndex = 9;
            // 
            // zipCodeIpnutAdd
            // 
            zipCodeIpnutAdd.BorderStyle = BorderStyle.FixedSingle;
            zipCodeIpnutAdd.Location = new Point(189, 148);
            zipCodeIpnutAdd.Name = "zipCodeIpnutAdd";
            zipCodeIpnutAdd.Size = new Size(319, 31);
            zipCodeIpnutAdd.TabIndex = 8;
            // 
            // countryAddLabel
            // 
            countryAddLabel.AutoSize = true;
            countryAddLabel.Location = new Point(16, 198);
            countryAddLabel.Name = "countryAddLabel";
            countryAddLabel.Size = new Size(75, 25);
            countryAddLabel.TabIndex = 7;
            countryAddLabel.Text = "Country";
            // 
            // zipCodeAddLabel
            // 
            zipCodeAddLabel.AutoSize = true;
            zipCodeAddLabel.Location = new Point(14, 148);
            zipCodeAddLabel.Name = "zipCodeAddLabel";
            zipCodeAddLabel.Size = new Size(84, 25);
            zipCodeAddLabel.TabIndex = 6;
            zipCodeAddLabel.Text = "Zip Code";
            // 
            // cityInputAdd
            // 
            cityInputAdd.BorderStyle = BorderStyle.FixedSingle;
            cityInputAdd.Location = new Point(189, 90);
            cityInputAdd.Name = "cityInputAdd";
            cityInputAdd.Size = new Size(319, 31);
            cityInputAdd.TabIndex = 5;
            // 
            // streetInputAdd
            // 
            streetInputAdd.BorderStyle = BorderStyle.FixedSingle;
            streetInputAdd.Location = new Point(189, 43);
            streetInputAdd.Name = "streetInputAdd";
            streetInputAdd.Size = new Size(319, 31);
            streetInputAdd.TabIndex = 4;
            // 
            // cityAddLabel
            // 
            cityAddLabel.AutoSize = true;
            cityAddLabel.Location = new Point(16, 90);
            cityAddLabel.Name = "cityAddLabel";
            cityAddLabel.Size = new Size(42, 25);
            cityAddLabel.TabIndex = 3;
            cityAddLabel.Text = "City";
            // 
            // streetAddLabel
            // 
            streetAddLabel.AutoSize = true;
            streetAddLabel.Location = new Point(14, 43);
            streetAddLabel.Name = "streetAddLabel";
            streetAddLabel.Size = new Size(57, 25);
            streetAddLabel.TabIndex = 2;
            streetAddLabel.Text = "Street";
            // 
            // confrimAddButton
            // 
            confrimAddButton.DialogResult = DialogResult.OK;
            confrimAddButton.Location = new Point(121, 788);
            confrimAddButton.Name = "confrimAddButton";
            confrimAddButton.Size = new Size(202, 34);
            confrimAddButton.TabIndex = 11;
            confrimAddButton.Text = "OK";
            confrimAddButton.UseVisualStyleBackColor = true;
            confrimAddButton.Click += OKButtonClick;
            // 
            // cancelAddButton
            // 
            cancelAddButton.DialogResult = DialogResult.Cancel;
            cancelAddButton.Location = new Point(402, 788);
            cancelAddButton.Name = "cancelAddButton";
            cancelAddButton.Size = new Size(202, 34);
            cancelAddButton.TabIndex = 12;
            cancelAddButton.Text = "Cancel";
            cancelAddButton.UseVisualStyleBackColor = true;
            cancelAddButton.Click += CancelClick;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 837);
            Controls.Add(cancelAddButton);
            Controls.Add(confrimAddButton);
            Controls.Add(addressBoxAdd);
            Controls.Add(contactBoxAdd);
            Controls.Add(nameBoxAdd);
            Name = "ContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Customer";
            Load += ContactForm_Load;
            nameBoxAdd.ResumeLayout(false);
            nameBoxAdd.PerformLayout();
            contactBoxAdd.ResumeLayout(false);
            contactBoxAdd.PerformLayout();
            addressBoxAdd.ResumeLayout(false);
            addressBoxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox nameBoxAdd;
        private TextBox lastNameInputAdd;
        private TextBox firstNameInputAdd;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private GroupBox contactBoxAdd;
        private TextBox privateMailInputAdd;
        private TextBox workMailInputAdd;
        private Label mailPrivateLabel;
        private Label mailWorkLAbel;
        private TextBox cellPhoneInputAdd;
        private TextBox homePhoneInputAdd;
        private Label cellPhoneInput;
        private Label homePhoneInput;
        private GroupBox addressBoxAdd;
        private TextBox zipCodeIpnutAdd;
        private Label countryAddLabel;
        private Label zipCodeAddLabel;
        private TextBox cityInputAdd;
        private TextBox streetInputAdd;
        private Label cityAddLabel;
        private Label streetAddLabel;
        private ComboBox countrySelectionAdd;
        private Button confrimAddButton;
        private Button cancelAddButton;
    }
}