namespace UI_WinForm.Forms
{
    partial class frmMain
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
            dgvContactList = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnDetails = new Button();
            btnAddContact = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            SuspendLayout();
            // 
            // dgvContactList
            // 
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Dock = DockStyle.Bottom;
            dgvContactList.Location = new Point(0, 258);
            dgvContactList.Margin = new Padding(4);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.RowHeadersWidth = 51;
            dgvContactList.RowTemplate.Height = 29;
            dgvContactList.Size = new Size(502, 370);
            dgvContactList.TabIndex = 0;
            dgvContactList.DoubleClick += dgvContactList_DoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(259, 31);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(259, 41);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(259, 24);
            label1.TabIndex = 3;
            label1.Text = "کلمه مورد نظر برای جستجو را در کادر وارد کنید";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(323, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 41);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف مخاطب";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(323, 143);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(144, 41);
            btnDetails.TabIndex = 5;
            btnDetails.Text = "جزئیات مخاطب";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(323, 42);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(144, 41);
            btnAddContact.TabIndex = 6;
            btnAddContact.Text = "افزودن مخاطب جدید";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(323, 92);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(144, 41);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ویرایش مخاطب";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 628);
            Controls.Add(btnEdit);
            Controls.Add(btnAddContact);
            Controls.Add(btnDetails);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvContactList);
            Font = new Font("B Nazanin", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContactList;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnDetails;
        private Button btnAddContact;
        private Button btnEdit;
    }
}