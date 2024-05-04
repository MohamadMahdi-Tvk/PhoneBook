using BLL.Dto;
using BLL.Services;
using DAL.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_WinForm.Forms
{
    public partial class frmMain : Form
    {
        private readonly ContactService _contactService;
        public frmMain()
        {
            InitializeComponent();
            _contactService = new ContactService();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var contactList = _contactService.GetContactList();
            SettingGridView(contactList);
            this.Cursor = Cursors.Default;

        }

        private void SettingGridView(List<ContactListDto> contactList)
        {
            dgvContactList.DataSource = contactList;
            dgvContactList.Columns[0].HeaderText = "شناسه";
            dgvContactList.Columns[1].HeaderText = "نام";
            dgvContactList.Columns[2].HeaderText = "شماره تلفن";

            dgvContactList.Columns[1].Width = 200;
            dgvContactList.Columns[2].Width = 200;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var contactList = _contactService.SearchContact(txtSearch.Text);

            SettingGridView(contactList);

            this.Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dgvContactList.CurrentRow.Cells[0].Value.ToString());

            var result = _contactService.DeleteContact(id);
            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowDetail()
        {
            var id = int.Parse(dgvContactList.CurrentRow.Cells[0].Value.ToString());

            frmDetails frmDetails = new frmDetails(id);
            frmDetails.ShowDialog();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void dgvContactList_DoubleClick(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddContact frmAddContact = new frmAddContact();
            frmAddContact.ShowDialog();

            frmMain_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var contactId = int.Parse(dgvContactList.CurrentRow.Cells[0].Value.ToString());

            frmEdit frmEdit = new frmEdit(contactId);
            frmEdit.ShowDialog();

            frmMain_Load(null, null);
        }
    }
}
