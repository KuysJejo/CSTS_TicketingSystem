using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;    

namespace TicketingSystem
{
    internal class CurrentUser
    {

        //START OF SQL connection CODE ko

        private static readonly SqlConnection conn = DatabaseHelper.GetConnection();
        private static SqlCommand cmd = null;
        private static SqlDataReader reader = null;

        //END OF SQL connection CODE ko



        private static string username { get; set; }
        
        private static string password { get; set; }



        //gagamitin sa ibang forms sa mga inaupdate na mga data
        internal static string FirstName { get; set; }
        internal static string LastName { get; set; }
        internal static int userID { get; set; }
        internal static string UserType { get; set; }




        internal static void Login(frmLogin loginform, string _username, string _password)
        {
            if (_username == "" || _password == "")
            {
                //should not be blank
                MessageBox.Show("Please enter a username and password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                loginform.txtUserName.Focus();
            }
            else if (_username.ToLower() == "admin" && _password.ToLower() == "admin")
            {
                //check muna kung admin default:
                frmHomePage _homePageAdmin = new frmHomePage();
                _homePageAdmin.Show();
                loginform.Hide();
            }
            //check sa database naman kung admin o hindi:
            else
            {

                try
                {
                    string query = "SELECT * FROM tblUsers WHERE username = @username AND password = @password";
                   
                    DatabaseHelper.ConnCloseOpen();


                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", _username);
                    cmd.Parameters.AddWithValue("@password", _password);    
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //user exists
                        reader.Read();
                        

                            //data from database:

                            string _userType = reader["role"].ToString();
                            string _userStatus = reader["status"].ToString();
                            string _pw = reader["password"].ToString();
                            int _userID = int.Parse(reader["Id"].ToString());
                            string _firstName = reader["firstname"].ToString();
                            string _lastName = reader["lastname"].ToString();

                        if (_userStatus.ToLower() != "active")
                        {
                            MessageBox.Show("Your account is not active. Please contact the system administrator.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            loginform.txtUserName.Focus();
                        }
                        else
                        {
                            //para ma-set kung sino naka-login
                            CurrentUser.username = _username;
                            CurrentUser.userID = _userID;
                            CurrentUser.password = _pw;
                            CurrentUser.FirstName = _firstName;
                            CurrentUser.LastName = _lastName;
                            CurrentUser.UserType = _userType;

                            //to chcck USER TYPE:

                            if (_userType.ToLower() == "admin")
                            {
                                //admin
                                frmHomePage _homePageAdmin = new frmHomePage();
                                _homePageAdmin.lblWelcomeName.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";

                                //hide or show other features
                                _homePageAdmin.btnUserMgt.Visible = true;
                                _homePageAdmin.btbCatMgt.Visible = true;
                                _homePageAdmin.lblUrgency.Visible = true;
                                _homePageAdmin.cmbPriorityLevel.Visible = true;
                                _homePageAdmin.cmbPriorityLevel.SelectedIndex = 0;
                                _homePageAdmin.cmbFilterStatus.SelectedIndex = 0;

                                _homePageAdmin.btnNewTicket.Visible = false;
                                _homePageAdmin.strCountPriority.Visible = true;


                                _homePageAdmin.Show();
                                loginform.Hide();

                      

                            }
                            else
                            {
                                //user
                                frmHomePage _homePageUser = new frmHomePage();
                                _homePageUser.lblWelcomeName.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";


                                //hide or show other features
                                _homePageUser.btnUserMgt.Visible = false;
                                _homePageUser.btbCatMgt.Visible = false;
                                _homePageUser.lblUrgency.Visible = false;
                                _homePageUser.cmbPriorityLevel.Visible = false;
                                _homePageUser.cmbFilterStatus.SelectedIndex = 0;

                                _homePageUser.btnNewTicket.Visible = true;


                                _homePageUser.strCountPriority.Visible =false;

                                _homePageUser.Show();
                                loginform.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        loginform.txtUserName.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\nContact System Administrator.","Login Error");
                }

            }
        }



        internal static void LoadProfile(frmProfile profileForm)
        {

            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "SELECT * FROM tblUsers WHERE Id = @userid";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", CurrentUser.userID); 
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        profileForm.txtUserName.Text = reader["username"].ToString();
                        profileForm.txtFirstName.Text = reader["firstname"].ToString();
                        profileForm.txtLastName.Text = reader["lastname"].ToString();
                        profileForm.txtEmailAdd.Text = reader["emailaddress"].ToString();
                        profileForm.txtContactNumber.Text = reader["contactnumber"].ToString();
                        profileForm.txtRole.Text = reader["role"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nContact System Administrator.");

            }
        }



        internal static void UpdateProfile(frmProfile profileForm, string _username, string _emailaddress, string _contractnumber)
        {
            DatabaseHelper.ConnCloseOpen();
            string query = "UPDATE tblUsers SET username = @username, emailaddress = @emailaddress, contactnumber = @contactnumber WHERE Id = @Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", _username);
            cmd.Parameters.AddWithValue("@emailaddress", _emailaddress);
            cmd.Parameters.AddWithValue("@contactnumber", _contractnumber);
            cmd.Parameters.AddWithValue("@Id", CurrentUser.userID);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Profile updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                profileForm.Close();
            }

        }



        internal static void ChangePW(frmProfile profileForm, string _newpassword)
        {
            if (profileForm.txtOldPW.Text=="" || profileForm.txtnewPW1.Text=="" || profileForm.txtnewPW2.Text=="")
            {
                MessageBox.Show("Please fill in all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (profileForm.txtOldPW.Text != CurrentUser.password)
            {
                MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                profileForm.txtOldPW.Focus();
            }
            else if (profileForm.txtnewPW1.Text != profileForm.txtnewPW2.Text)
            {
                MessageBox.Show("New password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                DatabaseHelper.ConnCloseOpen();
                string query = "UPDATE tblUsers SET password = @password WHERE Id = @Id";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", _newpassword);
                cmd.Parameters.AddWithValue("@Id", CurrentUser.userID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //set the current logged in pw
                    CurrentUser.password = profileForm.txtnewPW1.Text;
                    profileForm.btnChangePW.Visible = true;
                    profileForm.grpChangePW.Visible = false;
                    profileForm.txtOldPW.Clear();
                    profileForm.txtnewPW1.Clear();
                    profileForm.txtnewPW2.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to change password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    profileForm.txtOldPW.Focus();
                }

            }
        }







    }
}
