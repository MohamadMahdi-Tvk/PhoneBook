namespace UI_WinForm.Forms
{
    partial class frmEdit
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
            btnClose = new Button();
            btnEdit = new Button();
            txtDescription = new TextBox();
            txtCompany = new TextBox();
            txtPhoneNumber = new TextBox();
            txtFamily = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(298, 486);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(188, 57);
            btnClose.TabIndex = 24;
            btnClose.Text = "بازگشت به لیست";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(58, 486);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 57);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "ویرایش مخاطب";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(186, 318);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(261, 111);
            txtDescription.TabIndex = 22;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(186, 250);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(261, 37);
            txtCompany.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(186, 185);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(261, 37);
            txtPhoneNumber.TabIndex = 20;
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(186, 122);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(261, 37);
            txtFamily.TabIndex = 19;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(261, 37);
            txtName.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(40, 318);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 38);
            label5.TabIndex = 17;
            label5.Text = "توضیحات:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 38);
            label4.TabIndex = 16;
            label4.Text = "شماره موبایل:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 243);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 38);
            label3.TabIndex = 15;
            label3.Text = "نام شرکت:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 38);
            label2.TabIndex = 14;
            label2.Text = "نام خانوادگی:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 38);
            label1.TabIndex = 13;
            label1.Text = "نام: ";
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 605);
            Controls.Add(btnClose);
            Controls.Add(btnEdit);
            Controls.Add(txtDescription);
            Controls.Add(txtCompany);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFamily);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Nazanin", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmEdit";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "فرم ویرایش مخاطب";
            Load += frmEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnEdit;
        private TextBox txtDescription;
        private TextBox txtCompany;
        private TextBox txtPhoneNumber;
        private TextBox txtFamily;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}