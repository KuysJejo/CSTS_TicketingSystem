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
    public partial class frmTicketAdd : Form
    {
        public frmTicketAdd()
        {
            InitializeComponent();
        }

        private void frmTicketAdd_Load(object sender, EventArgs e)
        {
            //fetch UserInformation
            Ticket.LoadRequestorInfoAdd(this, CurrentUser.userID.ToString());

            //fetch Categories
            Ticket.LoadCategories(this);
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entered data will be lost.", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtTitle.Text == "" || txtDescription.Text == "" || cmbTicketCategory.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Ticket.AddNewTicket(this);
                this.Close();
                
            }
        }

        private void cmbTicketCategory_TextChanged(object sender, EventArgs e)
        {
            cmbTicketCategory.Text = "";
        }
    }
}
