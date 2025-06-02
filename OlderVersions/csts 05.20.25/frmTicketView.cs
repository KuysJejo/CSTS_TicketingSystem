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
    public partial class frmTicketView : Form
        {
        public frmTicketView()
        {
            InitializeComponent();
        }

        private void frmTicketView_Load(object sender, EventArgs e)
        {
            Ticket.ViewTicketDeets(this, Ticket.CurrentTicketID);
            Ticket.LoadNotes(this, Ticket.CurrentTicketID);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if(txtAddNote.Text != "")
            {
                Ticket.AddNotes(this, Ticket.CurrentTicketID, txtAddNote.Text);
                txtAddNote.Text = "";
                Ticket.ViewTicketDeets(this, Ticket.CurrentTicketID);
                Ticket.LoadNotes(this, Ticket.CurrentTicketID);

            }
            else
            {
                MessageBox.Show("Please enter a note before adding.");
            }
        }

        private void dgvNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotes.RowCount != 0)
            {


                if (dgvNotes.SelectedRows.Count > 0)
                {
                    frmTicketNoteView _noteView = new frmTicketNoteView();
                    _noteView.txtDateAdded.Text = dgvNotes.SelectedCells[0].Value.ToString();
                    _noteView.txtAddedBy.Text = dgvNotes.SelectedCells[1].Value.ToString();
                    _noteView.txtNote.Text = dgvNotes.SelectedCells[2].Value.ToString();
                    _noteView.ShowDialog();

                }
            }
        }

        private void frmTicketView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ticket.hasAddedNotes = false;
        }

        private void frmTicketView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ticket.hasAddedNotes = false;
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            if (txtTicketStatus.Text == "New")
            {
                MessageBox.Show("No need to re-submit the ticket since the ticket is still \'New\'. Feel free to add additional details to help expedite the process of reviewing your case.", "Input error");
            }
            else {
                if (Ticket.hasAddedNotes == true)
                {
                    Ticket.ActionSelected = 1;
                    Ticket.UpdateStatus(this, Ticket.ActionSelected);
                    Ticket.ViewTicketDeets(this, Ticket.CurrentTicketID);
                    Ticket.LoadNotes(this, Ticket.CurrentTicketID);
                }
                else
                {
                    MessageBox.Show("Please add a note before re-submitting the ticket to admin.", "Input Error");
                } 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this ticket? This will be marked as cancelled and will not be processed.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Ticket.hasAddedNotes == true)
                {
                    Ticket.ActionSelected = 2;
                    Ticket.UpdateStatus(this, Ticket.ActionSelected);
                    Ticket.ViewTicketDeets(this, Ticket.CurrentTicketID);
                    Ticket.LoadNotes(this, Ticket.CurrentTicketID);
                }
                else
                {
                    MessageBox.Show("Please add a note before cancelling the ticket.", "Input Error");
                }
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            if (Ticket.hasAddedNotes == true)
            {
                Ticket.ActionSelected = 3;
                Ticket.UpdateStatus(this, Ticket.ActionSelected);
                Ticket.ViewTicketDeets(this, Ticket.CurrentTicketID);
                Ticket.LoadNotes(this, Ticket.CurrentTicketID);
            }
            else
            {
                MessageBox.Show("Please add a note before returning the ticket to the requestor", "Input Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to mark this ticket as Closed/Resolved?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Ticket.hasAddedNotes == true)
                {
                    Ticket.ActionSelected = 4;
                    Ticket.UpdateStatus(this, Ticket.ActionSelected);
                    Ticket.ViewTicketDeets(this, Ticket.CurrentTicketID);
                    Ticket.LoadNotes(this, Ticket.CurrentTicketID);
                }
                else
                {
                    MessageBox.Show("Please add a note before marking the ticket as closed/resolved.", "Input Error");
                }
            }
        }

        private int tick = 0;

        private void tmrNoteSuccess_Tick(object sender, EventArgs e)
        {
            tick++;
            if (tick == 15) //total of 15 seconds, 1000 is in milliseconds
            {
                lblAddNoteSuccess.Visible = false;
                tmrNoteSuccess.Enabled = false;
                tick = 0;
            }
        }
    }
}
