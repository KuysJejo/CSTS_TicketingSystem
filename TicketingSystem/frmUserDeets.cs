using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class frmUserDeets : Form
    {
        public frmUserDeets()
        {
            InitializeComponent();
        }

        private void frmUserDeets_Load(object sender, EventArgs e)
        {
            //code to load data from database of transfer from previous form

            Users.LoadUserDeets(this);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEditSave.Text = "Edit";
            btnCancel.Visible = false;

            Users.LoadUserDeets(this);


        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (btnEditSave.Text == "Edit")
            {

                btnEditSave.Text = "Save";
                btnCancel.Visible = true;

                cmbStatus.Enabled = true;
                cmbRole.Enabled = true;
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtEmail.Enabled = true;
                txtContactNo.Enabled = true;
                txtNotes.Enabled = true;
            }
            else
            {
                //OOP
                //
                Users.UpdateUser(this);

                btnEditSave.Text = "Edit";
                btnCancel.Visible = false;

                txtUserName.Enabled = false;
                cmbStatus.Enabled = false;
                cmbRole.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtEmail.Enabled = false;
                txtContactNo.Enabled = false;
                txtNotes.Enabled = false;

            }

        }
    }
}
