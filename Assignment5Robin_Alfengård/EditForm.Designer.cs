namespace Assignment5Robin_Alfengård
{
    partial class EditForm
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
            cancelEditButton = new Button();
            confrimEditButton = new Button();
            addressBoxEdit = new GroupBox();
            countrySelectionEdit = new ComboBox();
            zipCodeIpnutEdit = new TextBox();
            countryEditLabel = new Label();
            zipCodeEditLabel = new Label();
            cityInputEdit = new TextBox();
            streetInputEdit = new TextBox();
            cityEditLabel = new Label();
            streetEditLabel = new Label();
            contactBoxEdit = new GroupBox();
            privateMailInputEdit = new TextBox();
            workMailInputEdit = new TextBox();
            mailPrivateLabelEdit = new Label();
            mailWorkLabelEdit = new Label();
            cellPhoneInputEdit = new TextBox();
            homePhoneInputEdit = new TextBox();
            cellPhoneLabelEdit = new Label();
            homePhoneEdit = new Label();
            nameBoxEdit = new GroupBox();
            lastNameInputEdit = new TextBox();
            firstNameInputEdit = new TextBox();
            lastNameLabelEdit = new Label();
            firstNameLabelEdit = new Label();
            addressBoxEdit.SuspendLayout();
            contactBoxEdit.SuspendLayout();
            nameBoxEdit.SuspendLayout();
            SuspendLayout();
            // 
            // cancelEditButton
            // 
            cancelEditButton.Location = new Point(424, 771);
            cancelEditButton.Name = "cancelEditButton";
            cancelEditButton.Size = new Size(202, 34);
            cancelEditButton.TabIndex = 17;
            cancelEditButton.Text = "Cancel";
            cancelEditButton.UseVisualStyleBackColor = true;
            // 
            // confrimEditButton
            // 
            confrimEditButton.Location = new Point(143, 771);
            confrimEditButton.Name = "confrimEditButton";
            confrimEditButton.Size = new Size(202, 34);
            confrimEditButton.TabIndex = 16;
            confrimEditButton.Text = "OK";
            confrimEditButton.UseVisualStyleBackColor = true;
            // 
            // addressBoxEdit
            // 
            addressBoxEdit.Controls.Add(countrySelectionEdit);
            addressBoxEdit.Controls.Add(zipCodeIpnutEdit);
            addressBoxEdit.Controls.Add(countryEditLabel);
            addressBoxEdit.Controls.Add(zipCodeEditLabel);
            addressBoxEdit.Controls.Add(cityInputEdit);
            addressBoxEdit.Controls.Add(streetInputEdit);
            addressBoxEdit.Controls.Add(cityEditLabel);
            addressBoxEdit.Controls.Add(streetEditLabel);
            addressBoxEdit.Location = new Point(92, 498);
            addressBoxEdit.Name = "addressBoxEdit";
            addressBoxEdit.Size = new Size(616, 259);
            addressBoxEdit.TabIndex = 15;
            addressBoxEdit.TabStop = false;
            addressBoxEdit.Text = "Address";
            // 
            // countrySelectionEdit
            // 
            countrySelectionEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            countrySelectionEdit.FormattingEnabled = true;
            countrySelectionEdit.Location = new Point(189, 198);
            countrySelectionEdit.Name = "countrySelectionEdit";
            countrySelectionEdit.Size = new Size(319, 33);
            countrySelectionEdit.TabIndex = 9;
            // 
            // zipCodeIpnutEdit
            // 
            zipCodeIpnutEdit.BorderStyle = BorderStyle.FixedSingle;
            zipCodeIpnutEdit.Location = new Point(189, 148);
            zipCodeIpnutEdit.Name = "zipCodeIpnutEdit";
            zipCodeIpnutEdit.Size = new Size(319, 31);
            zipCodeIpnutEdit.TabIndex = 8;
            // 
            // countryEditLabel
            // 
            countryEditLabel.AutoSize = true;
            countryEditLabel.Location = new Point(16, 198);
            countryEditLabel.Name = "countryEditLabel";
            countryEditLabel.Size = new Size(75, 25);
            countryEditLabel.TabIndex = 7;
            countryEditLabel.Text = "Country";
            // 
            // zipCodeEditLabel
            // 
            zipCodeEditLabel.AutoSize = true;
            zipCodeEditLabel.Location = new Point(14, 148);
            zipCodeEditLabel.Name = "zipCodeEditLabel";
            zipCodeEditLabel.Size = new Size(84, 25);
            zipCodeEditLabel.TabIndex = 6;
            zipCodeEditLabel.Text = "Zip Code";
            // 
            // cityInputEdit
            // 
            cityInputEdit.BorderStyle = BorderStyle.FixedSingle;
            cityInputEdit.Location = new Point(189, 90);
            cityInputEdit.Name = "cityInputEdit";
            cityInputEdit.Size = new Size(319, 31);
            cityInputEdit.TabIndex = 5;
            // 
            // streetInputEdit
            // 
            streetInputEdit.BorderStyle = BorderStyle.FixedSingle;
            streetInputEdit.Location = new Point(189, 43);
            streetInputEdit.Name = "streetInputEdit";
            streetInputEdit.Size = new Size(319, 31);
            streetInputEdit.TabIndex = 4;
            // 
            // cityEditLabel
            // 
            cityEditLabel.AutoSize = true;
            cityEditLabel.Location = new Point(16, 90);
            cityEditLabel.Name = "cityEditLabel";
            cityEditLabel.Size = new Size(42, 25);
            cityEditLabel.TabIndex = 3;
            cityEditLabel.Text = "City";
            // 
            // streetEditLabel
            // 
            streetEditLabel.AutoSize = true;
            streetEditLabel.Location = new Point(14, 43);
            streetEditLabel.Name = "streetEditLabel";
            streetEditLabel.Size = new Size(57, 25);
            streetEditLabel.TabIndex = 2;
            streetEditLabel.Text = "Street";
            // 
            // contactBoxEdit
            // 
            contactBoxEdit.Controls.Add(privateMailInputEdit);
            contactBoxEdit.Controls.Add(workMailInputEdit);
            contactBoxEdit.Controls.Add(mailPrivateLabelEdit);
            contactBoxEdit.Controls.Add(mailWorkLabelEdit);
            contactBoxEdit.Controls.Add(cellPhoneInputEdit);
            contactBoxEdit.Controls.Add(homePhoneInputEdit);
            contactBoxEdit.Controls.Add(cellPhoneLabelEdit);
            contactBoxEdit.Controls.Add(homePhoneEdit);
            contactBoxEdit.Location = new Point(92, 217);
            contactBoxEdit.Name = "contactBoxEdit";
            contactBoxEdit.Size = new Size(616, 259);
            contactBoxEdit.TabIndex = 14;
            contactBoxEdit.TabStop = false;
            contactBoxEdit.Text = "Email and Phone";
            // 
            // privateMailInputEdit
            // 
            privateMailInputEdit.BorderStyle = BorderStyle.FixedSingle;
            privateMailInputEdit.Location = new Point(189, 198);
            privateMailInputEdit.Name = "privateMailInputEdit";
            privateMailInputEdit.Size = new Size(319, 31);
            privateMailInputEdit.TabIndex = 9;
            // 
            // workMailInputEdit
            // 
            workMailInputEdit.BorderStyle = BorderStyle.FixedSingle;
            workMailInputEdit.Location = new Point(189, 148);
            workMailInputEdit.Name = "workMailInputEdit";
            workMailInputEdit.Size = new Size(319, 31);
            workMailInputEdit.TabIndex = 8;
            // 
            // mailPrivateLabelEdit
            // 
            mailPrivateLabelEdit.AutoSize = true;
            mailPrivateLabelEdit.Location = new Point(16, 198);
            mailPrivateLabelEdit.Name = "mailPrivateLabelEdit";
            mailPrivateLabelEdit.Size = new Size(129, 25);
            mailPrivateLabelEdit.TabIndex = 7;
            mailPrivateLabelEdit.Text = "E-Mail (Private)";
            // 
            // mailWorkLabelEdit
            // 
            mailWorkLabelEdit.AutoSize = true;
            mailWorkLabelEdit.Location = new Point(14, 148);
            mailWorkLabelEdit.Name = "mailWorkLabelEdit";
            mailWorkLabelEdit.Size = new Size(118, 25);
            mailWorkLabelEdit.TabIndex = 6;
            mailWorkLabelEdit.Text = "E-Mail (Work)";
            // 
            // cellPhoneInputEdit
            // 
            cellPhoneInputEdit.BorderStyle = BorderStyle.FixedSingle;
            cellPhoneInputEdit.Location = new Point(189, 90);
            cellPhoneInputEdit.Name = "cellPhoneInputEdit";
            cellPhoneInputEdit.Size = new Size(319, 31);
            cellPhoneInputEdit.TabIndex = 5;
            // 
            // homePhoneInputEdit
            // 
            homePhoneInputEdit.BorderStyle = BorderStyle.FixedSingle;
            homePhoneInputEdit.Location = new Point(189, 43);
            homePhoneInputEdit.Name = "homePhoneInputEdit";
            homePhoneInputEdit.Size = new Size(319, 31);
            homePhoneInputEdit.TabIndex = 4;
            // 
            // cellPhoneLabelEdit
            // 
            cellPhoneLabelEdit.AutoSize = true;
            cellPhoneLabelEdit.Location = new Point(16, 90);
            cellPhoneLabelEdit.Name = "cellPhoneLabelEdit";
            cellPhoneLabelEdit.Size = new Size(95, 25);
            cellPhoneLabelEdit.TabIndex = 3;
            cellPhoneLabelEdit.Text = "Cell Phone";
            // 
            // homePhoneEdit
            // 
            homePhoneEdit.AutoSize = true;
            homePhoneEdit.Location = new Point(14, 43);
            homePhoneEdit.Name = "homePhoneEdit";
            homePhoneEdit.Size = new Size(116, 25);
            homePhoneEdit.TabIndex = 2;
            homePhoneEdit.Text = "Home Phone";
            // 
            // nameBoxEdit
            // 
            nameBoxEdit.Controls.Add(lastNameInputEdit);
            nameBoxEdit.Controls.Add(firstNameInputEdit);
            nameBoxEdit.Controls.Add(lastNameLabelEdit);
            nameBoxEdit.Controls.Add(firstNameLabelEdit);
            nameBoxEdit.Location = new Point(92, 32);
            nameBoxEdit.Name = "nameBoxEdit";
            nameBoxEdit.Size = new Size(616, 161);
            nameBoxEdit.TabIndex = 13;
            nameBoxEdit.TabStop = false;
            nameBoxEdit.Text = "Name";
            // 
            // lastNameInputEdit
            // 
            lastNameInputEdit.BorderStyle = BorderStyle.FixedSingle;
            lastNameInputEdit.Location = new Point(189, 102);
            lastNameInputEdit.Name = "lastNameInputEdit";
            lastNameInputEdit.Size = new Size(319, 31);
            lastNameInputEdit.TabIndex = 5;
            // 
            // firstNameInputEdit
            // 
            firstNameInputEdit.BorderStyle = BorderStyle.FixedSingle;
            firstNameInputEdit.Location = new Point(189, 43);
            firstNameInputEdit.Name = "firstNameInputEdit";
            firstNameInputEdit.Size = new Size(319, 31);
            firstNameInputEdit.TabIndex = 4;
            // 
            // lastNameLabelEdit
            // 
            lastNameLabelEdit.AutoSize = true;
            lastNameLabelEdit.Location = new Point(16, 102);
            lastNameLabelEdit.Name = "lastNameLabelEdit";
            lastNameLabelEdit.Size = new Size(95, 25);
            lastNameLabelEdit.TabIndex = 3;
            lastNameLabelEdit.Text = "Last Name";
            // 
            // firstNameLabelEdit
            // 
            firstNameLabelEdit.AutoSize = true;
            firstNameLabelEdit.Location = new Point(14, 43);
            firstNameLabelEdit.Name = "firstNameLabelEdit";
            firstNameLabelEdit.Size = new Size(97, 25);
            firstNameLabelEdit.TabIndex = 2;
            firstNameLabelEdit.Text = "First Name";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 837);
            Controls.Add(cancelEditButton);
            Controls.Add(confrimEditButton);
            Controls.Add(addressBoxEdit);
            Controls.Add(contactBoxEdit);
            Controls.Add(nameBoxEdit);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Customer";
            addressBoxEdit.ResumeLayout(false);
            addressBoxEdit.PerformLayout();
            contactBoxEdit.ResumeLayout(false);
            contactBoxEdit.PerformLayout();
            nameBoxEdit.ResumeLayout(false);
            nameBoxEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelEditButton;
        private Button confrimEditButton;
        private GroupBox addressBoxEdit;
        private ComboBox countrySelectionEdit;
        private TextBox zipCodeIpnutEdit;
        private Label countryEditLabel;
        private Label zipCodeEditLabel;
        private TextBox cityInputEdit;
        private TextBox streetInputEdit;
        private Label cityEditLabel;
        private Label streetEditLabel;
        private GroupBox contactBoxEdit;
        private TextBox privateMailInputEdit;
        private TextBox workMailInputEdit;
        private Label mailPrivateLabelEdit;
        private Label mailWorkLabelEdit;
        private TextBox cellPhoneInputEdit;
        private TextBox homePhoneInputEdit;
        private Label cellPhoneLabelEdit;
        private Label homePhoneEdit;
        private GroupBox nameBoxEdit;
        private TextBox lastNameInputEdit;
        private TextBox firstNameInputEdit;
        private Label lastNameLabelEdit;
        private Label firstNameLabelEdit;
    }
}