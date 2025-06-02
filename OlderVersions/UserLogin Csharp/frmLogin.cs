using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.CodeDom;


namespace TicketingSystem
{
    public partial class frmLogin : Form
    {



        //START OF SQL connection CODE ko

        private static SqlConnection conn = DatabaseHelper.GetConnection();
        private static SqlCommand cmd = null;
        private static SqlDataReader reader = null;

        //END OF SQL connection CODE ko



        public frmLogin()
        {
            InitializeComponent();

        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            //OOP
            //
            CurrentUser.Login(this, txtUserName.Text, txtPassword.Text);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }




        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.Focus();
            }
        }



        private void btntest_Click(object sender, EventArgs e)
        {
            ///temp code
            ///
            ///
            frmUsersList _frmusers = new frmUsersList();
            _frmusers.Show();
            this.Hide();
            ///
            ///
            ///end of temp code
        }
    }
}
