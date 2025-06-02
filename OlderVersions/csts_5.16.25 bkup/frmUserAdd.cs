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
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {

              //ADD TEMPORARY PASSWORD

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Users.CheckIfUserExists(this) == false)
            {
                Users.AddNewUser(this);
            }

        }
    }
}
