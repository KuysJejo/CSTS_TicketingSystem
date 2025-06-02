using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Reflection;



namespace TicketingSystem
{
    internal class Users
    {



        //START OF SQL connection CODE ko
        private static readonly SqlConnection conn = DatabaseHelper.GetConnection();
        private static SqlCommand cmd = null;
        private static SqlDataReader reader = null;
        //END OF SQL connection CODE ko



        //STATIC VARIABLES
        private static int UID { get; set; }
        private static string UserName { get; set; }
        private static string Status { get; set; }
        private static string Role { get; set; }
        private static string FirstName { get; set; }
        private static string LastName { get; set; }
        private static string Email { get; set; }
        private static string Contact { get; set; }



        //variable for row location after selection
        internal static int selectedRowIndex = -1;

        //variable for selected record
        internal static string SelectedUser {  get; set; }







        //MY FUNCTIONS
        //

        //load ng userl list sa dgv
        internal static void LoadRecords(frmUsersList _frmuserlist) {

                _frmuserlist.dgvUsersList.Rows.Clear();
                _frmuserlist.dgvUsersList.Refresh();
                _frmuserlist.dgvUsersList.MultiSelect = false;
                _frmuserlist.dgvUsersList.RowHeadersVisible = false;
                



                DatabaseHelper.ConnCloseOpen();

                try
                {
                    string query = "SELECT * FROM tblUsers";
                    DatabaseHelper.ConnCloseOpen();

                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //load the users into the datagridview
                            UID = int.Parse(reader["ID"].ToString());
                            UserName = reader["UserName"].ToString();
                            Status = reader["Status"].ToString();
                            Role = reader["Role"].ToString();
                            FirstName = reader["firstname"].ToString();
                            LastName = reader["lastname"].ToString();
                            Email = reader["emailaddress"].ToString();
                            Contact = reader["contactnumber"].ToString();

                            //add to the datagridview
                            _frmuserlist.dgvUsersList.Rows.Add(UID, UserName, Status, Role, FirstName, LastName, Email, Contact);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Users found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();

                    _frmuserlist.dgvUsersList.ClearSelection(); 
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }


        }

        //pang add ng bagong user
        internal static void AddNewUser (frmUserAdd _adduserform)
        {
            //check if the fields are empty
            if (_adduserform.txtUserName.Text == "" || _adduserform.txtFirstName.Text == "" || _adduserform.txtLastName.Text == "" || _adduserform.txtEmail.Text == "" || _adduserform.txtContactNo.Text == "" || _adduserform.cmbRole.Text == "" || _adduserform.cmbStatus.Text == "" || _adduserform.TxtTempPassword.Text == "")
                MessageBox.Show("Please fill in all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string query = "INSERT INTO tblUsers (UserName, password, Status, Role, firstname, lastname, emailaddress, contactnumber, notes) VALUES (@UserName, @password, @Status, @Role, @firstname, @lastname, @emailaddress, @contactnumber, @notes)";
                DatabaseHelper.ConnCloseOpen();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", _adduserform.txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", _adduserform.TxtTempPassword.Text);
                cmd.Parameters.AddWithValue("@Status", _adduserform.cmbStatus.Text);
                cmd.Parameters.AddWithValue("@Role", _adduserform.cmbRole.Text);
                cmd.Parameters.AddWithValue("@firstname", _adduserform.txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", _adduserform.txtLastName.Text);
                cmd.Parameters.AddWithValue("@emailaddress", _adduserform.txtEmail.Text);
                cmd.Parameters.AddWithValue("@contactnumber", _adduserform.txtContactNo.Text);
                cmd.Parameters.AddWithValue("@notes", _adduserform.txtNotes.Text);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Added Successfully");
                    _adduserform.Close();
                }
                else
                {
                    MessageBox.Show("Error Adding User");
                }
                conn.Close();
            }

        }

        //reselect ng row sa dgv
        internal static void ReselectRow(frmUsersList _userlistform)
        {

            //reselect 'yung data row
            _userlistform.dgvUsersList.CurrentCell = _userlistform.dgvUsersList.Rows[selectedRowIndex].Cells[0];

        }

        //load ng information ng user
        internal static void LoadUserDeets(frmUserDeets _frmuserdeet)
        {
            

            try
            {
                string query = "SELECT * FROM tblUsers WHERE ID = @uid";
                DatabaseHelper.ConnCloseOpen();

                cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@uid", Users.SelectedUser);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();


                    //load the user data intp the form
                    _frmuserdeet.txtUserName.Text = reader["UserName"].ToString();
                    _frmuserdeet.cmbStatus.Text = reader["Status"].ToString();
                    _frmuserdeet.cmbRole.Text = reader["Role"].ToString();
                    _frmuserdeet.txtFirstName.Text = reader["firstname"].ToString();
                    _frmuserdeet.txtLastName.Text = reader["lastname"].ToString();
                    _frmuserdeet.txtEmail.Text = reader["emailaddress"].ToString();
                    _frmuserdeet.txtContactNo.Text = reader["contactnumber"].ToString();
                    _frmuserdeet.txtNotes.Text = reader["notes"].ToString();

                    //set again the selected user
                    Users.SelectedUser = reader["ID"].ToString();

                    _frmuserdeet.btnEditSave.Text = "Edit";
                    _frmuserdeet.btnCancel.Visible = false;


                    _frmuserdeet.txtUserName.Enabled = false;
                    _frmuserdeet.cmbStatus.Enabled = false;
                    _frmuserdeet.cmbRole.Enabled = false;
                    _frmuserdeet.txtFirstName.Enabled = false;
                    _frmuserdeet.txtLastName.Enabled = false;
                    _frmuserdeet.txtEmail.Enabled = false;
                    _frmuserdeet.txtContactNo.Enabled = false;
                    _frmuserdeet.txtNotes.Enabled = false;




                }
                else
                {
                    MessageBox.Show("No Users found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }






        }

        //pang update
        internal static void UpdateUser(frmUserDeets _frmuserdeet)
        {
            try {
                string query = "UPDATE tblUsers SET Status = @Status, Role = @Role, firstname = @firstname, lastname = @lastname, emailaddress = @emailaddress, contactnumber = @contactnumber, notes = @notes WHERE ID = @uid";
                DatabaseHelper.ConnCloseOpen();

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@uid", SelectedUser);
                cmd.Parameters.AddWithValue("@Status", _frmuserdeet.cmbStatus.Text);
                cmd.Parameters.AddWithValue("@Role", _frmuserdeet.cmbRole.Text);
                cmd.Parameters.AddWithValue("@firstname", _frmuserdeet.txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", _frmuserdeet.txtLastName.Text);
                cmd.Parameters.AddWithValue("@emailaddress", _frmuserdeet.txtEmail.Text);
                cmd.Parameters.AddWithValue("@contactnumber", _frmuserdeet.txtContactNo.Text);
                cmd.Parameters.AddWithValue("@notes", _frmuserdeet.txtNotes.Text);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("User Updated Successfully");
                    Users.LoadUserDeets(_frmuserdeet);
                }
                else
                {
                    MessageBox.Show("Error Updating User");
                }
                conn.Close();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Users.LoadUserDeets(_frmuserdeet);
            }
        }

        //pang search
        internal static void SearchRecord(frmUsersList _frmuserlist)
        {

            _frmuserlist.dgvUsersList.Rows.Clear();
            _frmuserlist.dgvUsersList.Refresh();
            _frmuserlist.dgvUsersList.MultiSelect = false;
            _frmuserlist.dgvUsersList.RowHeadersVisible = false;



            DatabaseHelper.ConnCloseOpen();

            try
            {
                string query = "";

                if (_frmuserlist.chkSearchOption.Checked == true)
                {
                    //search for users only
                    query = "SELECT * FROM tblUsers WHERE " +
                        "role = 'user' AND " +
                        "(UserName LIKE  CONCAT('%',@keyword,'%') OR " +
                        "Role LIKE CONCAT('%',@keyword,'%') OR " +
                        "firstname LIKE CONCAT('%',@keyword,'%') OR " +
                        "lastname LIKE CONCAT('%',@keyword,'%') OR " +
                        "status LIKE CONCAT('%',@keyword,'%') OR " +
                        "emailaddress LIKE CONCAT('%',@keyword,'%') OR " +
                        "contactnumber LIKE CONCAT('%',@keyword,'%'))";
                } else {
                     query = "SELECT * FROM tblUsers WHERE " +
                        "UserName LIKE CONCAT('%',@keyword,'%') OR " +
                        "Role LIKE CONCAT('%',@keyword,'%') OR " +
                        "firstname LIKE CONCAT('%',@keyword,'%') OR " +
                        "lastname LIKE CONCAT('%',@keyword,'%') OR " +
                        "status LIKE CONCAT('%',@keyword,'%') OR " +
                        "emailaddress LIKE CONCAT('%',@keyword,'%') OR " +
                        "contactnumber LIKE CONCAT('%',@keyword,'%')";
                }


                DatabaseHelper.ConnCloseOpen();

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", _frmuserlist.txtSearch.Text);


                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //load the users into the datagridview
                        UID = int.Parse(reader["ID"].ToString());
                        UserName = reader["UserName"].ToString();
                        Status = reader["Status"].ToString();
                        Role = reader["Role"].ToString();
                        FirstName = reader["firstname"].ToString();
                        LastName = reader["lastname"].ToString();
                        Email = reader["emailaddress"].ToString();
                        Contact = reader["contactnumber"].ToString();

                        //add to the datagridview
                        _frmuserlist.dgvUsersList.Rows.Add(UID, UserName, Status, Role, FirstName, LastName, Email, Contact);
                    }
                }
                conn.Close();

                _frmuserlist.dgvUsersList.ClearSelection();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }


        }

        //check para hindi multiple ang username
        internal static Boolean CheckIfUserExists(frmUserAdd _adduserform)
        {
            //check if the user already exists
            string query = "SELECT * FROM tblUsers WHERE UserName = @username";
            DatabaseHelper.ConnCloseOpen();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", _adduserform.txtUserName.Text);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
