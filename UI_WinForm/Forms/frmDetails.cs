using BLL.Services;
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
    public partial class frmDetails : Form
    {
        private readonly ContactService _contactService;
        private readonly int contactId;
        public frmDetails(int id)
        {
            InitializeComponent();
            _contactService = new ContactService();
            contactId = id;
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            var result = _contactService.ContactDetail(contactId);
            if (result.IsSuccess == false)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblId.Text = result.Data.Id.ToString();
            lblName.Text = result.Data.FirstName;
            lblFamily.Text = result.Data.LastName;
            lblCompany.Text = result.Data.CompanyName;
            lblPhoneNumber.Text = result.Data.PhoneNumber;
            lblDescription.Text = result.Data.Description;
            lblCreateDate.Text = result.Data.CreateAt.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
