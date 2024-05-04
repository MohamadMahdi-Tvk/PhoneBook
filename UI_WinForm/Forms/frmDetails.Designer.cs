namespace UI_WinForm.Forms
{
    partial class frmDetails
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
            label7 = new Label();
            lblId = new Label();
            lblName = new Label();
            lblFamily = new Label();
            lblCompany = new Label();
            lblPhoneNumber = new Label();
            lblCreateDate = new Label();
            lblDescription = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 47);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 34);
            label1.TabIndex = 0;
            label1.Text = "شناسه: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 104);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 34);
            label2.TabIndex = 1;
            label2.Text = "نام: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 161);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 34);
            label3.TabIndex = 2;
            label3.Text = "نام خانوادگی: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 219);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 34);
            label4.TabIndex = 3;
            label4.Text = "نام شرکت: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(59, 275);
            label5.Margin = new Padding(8, 0, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 34);
            label5.TabIndex = 4;
            label5.Text = "شماره تماس: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(59, 332);
            label6.Margin = new Padding(8, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 34);
            label6.TabIndex = 5;
            label6.Text = "تاریخ درج: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("B Nazanin", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(59, 389);
            label7.Margin = new Padding(8, 0, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 34);
            label7.TabIndex = 6;
            label7.Text = "توضیحات:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(250, 47);
            lblId.Name = "lblId";
            lblId.Size = new Size(88, 37);
            lblId.TabIndex = 7;
            lblId.Text = "label8";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(250, 104);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 37);
            lblName.TabIndex = 8;
            lblName.Text = "label9";
            // 
            // lblFamily
            // 
            lblFamily.AutoSize = true;
            lblFamily.Location = new Point(250, 161);
            lblFamily.Name = "lblFamily";
            lblFamily.Size = new Size(91, 37);
            lblFamily.TabIndex = 9;
            lblFamily.Text = "label10";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(250, 219);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(91, 37);
            lblCompany.TabIndex = 10;
            lblCompany.Text = "label11";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(250, 275);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(94, 37);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "label12";
            // 
            // lblCreateDate
            // 
            lblCreateDate.AutoSize = true;
            lblCreateDate.Location = new Point(250, 332);
            lblCreateDate.Name = "lblCreateDate";
            lblCreateDate.Size = new Size(96, 37);
            lblCreateDate.TabIndex = 12;
            lblCreateDate.Text = "label13";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(250, 389);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(95, 37);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "label14";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(143, 499);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(207, 48);
            btnClose.TabIndex = 14;
            btnClose.Text = "بازگشت به لیست";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmDetails
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(479, 588);
            Controls.Add(btnClose);
            Controls.Add(lblDescription);
            Controls.Add(lblCreateDate);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCompany);
            Controls.Add(lblFamily);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8, 5, 8, 5);
            Name = "frmDetails";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDetails";
            Load += frmDetails_Load;
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
        private Label label7;
        private Label lblId;
        private Label lblName;
        private Label lblFamily;
        private Label lblCompany;
        private Label lblPhoneNumber;
        private Label lblCreateDate;
        private Label lblDescription;
        private Button btnClose;
    }
}