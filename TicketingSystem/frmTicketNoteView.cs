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
    public partial class frmTicketNoteView : Form
    {
        public frmTicketNoteView()
        {
            InitializeComponent();
        }

        private void frmNoteView_Load(object sender, EventArgs e)
        {
            lblTicketNo.Text = "Note for Ticket No. " + Ticket.CurrentTicketID;

        }
    }
}
