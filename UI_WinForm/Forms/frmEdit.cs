using BLL.Dto;
using BLL.Services;
using DAL.Entities;
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
    public partial class frmEdit : Form
    {
        private readonly ContactService _contactService;
        private readonly int ContactId;
        public frmEdit(int ContactId)
        {
            InitializeComponent();
            _contactService = new ContactService();
            this.ContactId = ContactId;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            var contact = _contactService.ContactDetail(ContactId);

            if (contact.IsSuccess == false)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtName.Text = contact.Data.FirstName;
                txtFamily.Text = contact.Data.LastName;
                txtPhoneNumber.Text = contact.Data.PhoneNumber;
                txtCompany.Text = contact.Data.CompanyName;
                txtDescription.Text = contact.Data.Description;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var result = _contactService.EditContact(new EditContactDto
            {
                Id = ContactId,
                CompanyName = txtCompany.Text,
                Description = txtDescription.Text,
                LastName = txtFamily.Text,
                FirstName = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
            });

            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
