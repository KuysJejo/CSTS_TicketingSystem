using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin _frmLogin = new frmLogin();
            _frmLogin.Show();
            this.Close();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            frmProfile _frmProfile = new frmProfile();
            _frmProfile.ShowDialog();
        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            frmTicketAdd _frmTicketAdd = new frmTicketAdd();
            _frmTicketAdd.ShowDialog();
        }

        private void frmHomePageUser_Load(object sender, EventArgs e)
        {



            //oop
            //
            Ticket.LoadTickets_homepage(this);

            dgvTickets.ClearSelection();
            dgvTickets.RowHeadersVisible = false;



        }

        private void frmHomePageUser_Activated(object sender, EventArgs e)
        {

            Ticket.LoadTickets_homepage(this);

            dgvTickets.ClearSelection();
            dgvTickets.RowHeadersVisible = false;

        }

        private void btnUserMgt_Click(object sender, EventArgs e)
        {
            frmUsersList _frmuserslist = new frmUsersList();
            _frmuserslist.ShowDialog();

        }

        private void btbCatMgt_Click(object sender, EventArgs e)
        {
            frmCategories _frmCategories = new frmCategories();
            _frmCategories.ShowDialog();
            
        }

        private void cmbPriorityLevel_TextChanged(object sender, EventArgs e)
        {
            //prevent user typing
            cmbPriorityLevel.Text = "";

        }

        private void cmbPriorityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ticket.LoadTickets_homepage(this);
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ticket.LoadTickets_homepage(this);
        }

        private void cmbFilterStatus_TextChanged(object sender, EventArgs e)
        {
            //prevent user typing
            cmbFilterStatus.Text = "";
        }

        private void chkActiveTicketsOnly_CheckStateChanged(object sender, EventArgs e)
        {
            cmbFilterStatus.Text = "";
        }

        private void chkActiveTicketsOnly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Ticket.SearchTicket_homepage(this, txtsearch.Text);
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            dgvTickets.ClearSelection();

        }

        private void dgvTickets_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTickets.RowCount != 0)
            {

                //set kung ano ang selected row
                Ticket.selectedRowIndex = e.RowIndex;

                //set the curremt selection


                if (dgvTickets.SelectedRows.Count > 0)
                {
                    Ticket.CurrentTicketID = dgvTickets.SelectedCells[0].Value.ToString();

                    //load 'yung data sa isang form
                    frmTicketView _ticketvform = new frmTicketView();
                    _ticketvform.ShowDialog();

                    //reload ang data to reflect changes
                    Ticket.LoadTickets_homepage(this);

                    //reselect 'yung data row
                    Ticket.ReselectRow(this);
                }
            }

        }
    }
}
