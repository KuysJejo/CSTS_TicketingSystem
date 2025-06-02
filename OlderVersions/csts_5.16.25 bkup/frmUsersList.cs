using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class frmUsersList : Form
    {
        public frmUsersList()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmUserAdd _userAdd = new frmUserAdd();
            _userAdd.ShowDialog();

            //reload ang data to reflect changes
            Users.LoadRecords(this);



        }

        private void frmUsersList_Load(object sender, EventArgs e)
        {
            Users.LoadRecords(this);
        }

        private void dgvUsersList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsersList.RowCount != 0)
            {

                //set kung ano ang selected row
                Users.selectedRowIndex = e.RowIndex;

                //set the curremt selection


                if (dgvUsersList.SelectedRows.Count > 0)
                {
                    Users.SelectedUser = dgvUsersList.SelectedCells[0].Value.ToString();

                    //load 'yung data sa isang form
                    frmUserDeets _userDeets = new frmUserDeets();
                    _userDeets.ShowDialog();

                    //reload ang data to reflect changes
                    Users.LoadRecords(this);

                    //reselect 'yung data row
                    Users.ReselectRow(this);
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Users.LoadRecords(this);
            }
            else
            {
                //search
                Users.SearchRecord(this);
            }
            
        }

        private void chkSearchOption_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                //search
                Users.SearchRecord(this);
            } else
            {
                //search
                Users.LoadRecords(this);
            }

        }

        private void chkSearchOption_CheckStateChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                //search
                Users.SearchRecord(this);
            }
            else
            {
                //search
                Users.LoadRecords(this);
            }
        }
    }
}
