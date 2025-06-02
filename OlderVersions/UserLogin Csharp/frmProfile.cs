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
    public partial class frmProfile : Form
    {




        public frmProfile()
        {
            InitializeComponent();
        }


        private void frmProfile_Load(object sender, EventArgs e)
        {
 
            txtUserName.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtEmailAdd.Enabled = false;    
            txtContactNumber.Enabled = false;
            txtRole.Enabled = false;

            grpChangePW.Visible=false;

            btnEditSave.Text="Edit";





            //OOP
            //
            CurrentUser.LoadProfile(this);





        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            btnChangePW.Visible = false;
            grpChangePW.Visible = true;
            txtOldPW.Clear();
            txtnewPW1.Clear();
            txtnewPW2.Clear();  

            btnEditSave.Visible = false;    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnChangePW.Visible = true;
            grpChangePW.Visible = false;

            btnEditSave.Visible = true;

        }

        private void btnChangePWconfirm_Click(object sender, EventArgs e)
        {

                
                //OOP
                //update password based on input:
                CurrentUser.ChangePW(this, txtnewPW1.Text);


        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (btnEditSave.Text == "Edit")
            {
                txtUserName.Enabled = true;
                txtEmailAdd.Enabled = true;
                txtContactNumber.Enabled = true;



                btnEditSave.Text = "Save";
                btnCancelEdit.Visible = true;

                btnChangePW.Visible = false;    

            }
            else
            {
                //OOP
                //updates profile based on inputs 
                CurrentUser.UpdateProfile(this, txtUserName.Text, txtEmailAdd.Text, txtContactNumber.Text);


                txtUserName.Enabled = false;
                txtEmailAdd.Enabled = false;
                txtContactNumber.Enabled = false;
                btnEditSave.Text = "Edit";

                btnChangePW.Visible = true;

            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {


            //OOP
            //
            CurrentUser.LoadProfile(this);


            btnEditSave.Text = "Edit";  

            btnCancelEdit.Visible = false;


            txtUserName.Enabled = false;
            txtEmailAdd.Enabled = false;
            txtContactNumber.Enabled = false;

            btnChangePW.Visible = true;


        }
    }
}
