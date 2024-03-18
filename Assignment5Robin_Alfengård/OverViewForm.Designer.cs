namespace Assignment5Robin_Alfengård
{
    partial class OverViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listviewContactInfo = new ListView();
            idLabel = new Label();
            firstNameLabel = new Label();
            officePhoneLabel = new Label();
            officeMailLabel = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            contactDetailsLabel = new Label();
            ExpandedCustomerInfoTextBox = new TextBox();
            SuspendLayout();
            // 
            // listviewContactInfo
            // 
            listviewContactInfo.Location = new Point(50, 96);
            listviewContactInfo.Name = "listviewContactInfo";
            listviewContactInfo.Size = new Size(988, 623);
            listviewContactInfo.TabIndex = 0;
            listviewContactInfo.UseCompatibleStateImageBehavior = false;
            listviewContactInfo.View = View.List;
            listviewContactInfo.MouseClick += ShowExpandedCustomerInfoOnClick;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(50, 51);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(28, 25);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(206, 51);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(238, 25);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Name (last name, first name)";
            // 
            // officePhoneLabel
            // 
            officePhoneLabel.AutoSize = true;
            officePhoneLabel.Location = new Point(578, 51);
            officePhoneLabel.Name = "officePhoneLabel";
            officePhoneLabel.Size = new Size(114, 25);
            officePhoneLabel.TabIndex = 3;
            officePhoneLabel.Text = "Office Phone";
            // 
            // officeMailLabel
            // 
            officeMailLabel.AutoSize = true;
            officeMailLabel.Location = new Point(853, 51);
            officeMailLabel.Name = "officeMailLabel";
            officeMailLabel.Size = new Size(113, 25);
            officeMailLabel.TabIndex = 4;
            officeMailLabel.Text = "Office E-Mail";
            // 
            // addButton
            // 
            addButton.Location = new Point(50, 755);
            addButton.Name = "addButton";
            addButton.Size = new Size(171, 47);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += LoadAddCustomerFormClick;
            // 
            // editButton
            // 
            editButton.Location = new Point(443, 755);
            editButton.Name = "editButton";
            editButton.Size = new Size(171, 47);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(867, 755);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(171, 47);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // contactDetailsLabel
            // 
            contactDetailsLabel.AutoSize = true;
            contactDetailsLabel.Location = new Point(1259, 51);
            contactDetailsLabel.Name = "contactDetailsLabel";
            contactDetailsLabel.Size = new Size(131, 25);
            contactDetailsLabel.TabIndex = 8;
            contactDetailsLabel.Text = "Contact Details";
            // 
            // ExpandedCustomerInfoTextBox
            // 
            ExpandedCustomerInfoTextBox.BorderStyle = BorderStyle.FixedSingle;
            ExpandedCustomerInfoTextBox.Location = new Point(1082, 95);
            ExpandedCustomerInfoTextBox.Multiline = true;
            ExpandedCustomerInfoTextBox.Name = "ExpandedCustomerInfoTextBox";
            ExpandedCustomerInfoTextBox.ReadOnly = true;
            ExpandedCustomerInfoTextBox.Size = new Size(515, 624);
            ExpandedCustomerInfoTextBox.TabIndex = 9;
            // 
            // OverViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1651, 837);
            Controls.Add(ExpandedCustomerInfoTextBox);
            Controls.Add(contactDetailsLabel);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(officeMailLabel);
            Controls.Add(officePhoneLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(idLabel);
            Controls.Add(listviewContactInfo);
            Name = "OverViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += OverViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listviewContactInfo;
        private Label idLabel;
        private Label firstNameLabel;
        private Label officePhoneLabel;
        private Label officeMailLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Label contactDetailsLabel;
        private TextBox ExpandedCustomerInfoTextBox;
    }
}
