namespace UI_WinForm.Forms
{
    partial class frmAddContact
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtFamily = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCompany = new TextBox();
            txtDescription = new TextBox();
            btnAddNewContact = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 38);
            label1.TabIndex = 0;
            label1.Text = "نام: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 170);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 38);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 298);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 38);
            label3.TabIndex = 2;
            label3.Text = "نام شرکت:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 38);
            label4.TabIndex = 3;
            label4.Text = "شماره موبایل:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 373);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 4;
            label5.Text = "توضیحات:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("IRNazli", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(135, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(236, 36);
            label6.TabIndex = 5;
            label6.Text = "فرم افزودن مخاطب جدید";
            // 
            // txtName
            // 
            txtName.Location = new Point(200, 114);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 31);
            txtName.TabIndex = 6;
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(200, 177);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(261, 31);
            txtFamily.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(200, 240);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(261, 31);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(200, 305);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(261, 31);
            txtCompany.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 373);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(261, 111);
            txtDescription.TabIndex = 10;
            // 
            // btnAddNewContact
            // 
            btnAddNewContact.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewContact.Location = new Point(50, 512);
            btnAddNewContact.Name = "btnAddNewContact";
            btnAddNewContact.Size = new Size(188, 57);
            btnAddNewContact.TabIndex = 11;
            btnAddNewContact.Text = "افزودن مخاطب";
            btnAddNewContact.UseVisualStyleBackColor = true;
            btnAddNewContact.Click += btnAddNewContact_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(273, 512);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(188, 57);
            btnClose.TabIndex = 12;
            btnClose.Text = "بازگشت به لیست";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(498, 607);
            Controls.Add(btnClose);
            Controls.Add(btnAddNewContact);
            Controls.Add(txtDescription);
            Controls.Add(txtCompany);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFamily);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Nazanin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmAddContact";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن مخاطب جدید";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtFamily;
        private TextBox txtPhoneNumber;
        private TextBox txtCompany;
        private TextBox txtDescription;
        private Button btnAddNewContact;
        private Button btnClose;
    }
}