using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace TicketingSystem
{
    public partial class frmHomePageAdmin : Form
    {



        //START OF SQL connection CODE ko

        private static SqlConnection conn = DatabaseHelper.GetConnection();
        private static SqlCommand cmd = null;
        private static SqlDataReader reader = null;

        //END OF SQL connection CODE ko




        public frmHomePageAdmin()
        {
            InitializeComponent();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {


        }

        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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

        private void btbCatMgt_Click(object sender, EventArgs e)
        {
            frmCategories _frmCategories = new frmCategories();
            _frmCategories.ShowDialog();
        }
    }
}
