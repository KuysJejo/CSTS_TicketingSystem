using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Reflection;
using System.Linq.Expressions;

using System.Globalization;
using System.Runtime.CompilerServices;



namespace TicketingSystem
{
    internal class Ticket
    {

        //START OF SQL connection CODE ko

        private static readonly SqlConnection conn = DatabaseHelper.GetConnection();
        private static SqlCommand cmd = null;
        private static SqlDataReader reader1 = null;

        //END OF SQL connection CODE ko




        //variables ko:
        internal static string CurrentTicketID { get; set; }
        private static string Ticket_Status { get; set; }

        internal static int ActionSelected { get; set; }
        //1 = resubmit / inprogress
        //2 = cancelled by user / cancel
        //3 = return to requestor / pending
        //4 = close ticket // closed

        internal static Boolean hasAddedNotes { get; set; } = false;
        //to check if notes were added before selecting an action
        //form close = false
        //note saved = true

        //variable for row location after selection
        internal static int selectedRowIndex = -1;

        //ticket counts:
        private static int CountHigh {  get; set; }
        private static int CountMedium {  get; set; }
        private static int CountLow { get; set; }  
        private static int CountNew { get; set; }
        private static int CountInProgress { get; set; }
        private static int CountPending { get; set; }


        //for proper casing (title case)
        private static TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;


        //for add new ticket
        internal static void LoadRequestorInfoAdd(frmTicketAdd _frmticketAdd, string UID)
        {
            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "SELECT * FROM tblusers WHERE ID = @UserID";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UID);
                reader1 = cmd.ExecuteReader();

                if (reader1.HasRows)
                {
                    reader1.Read();

                    _frmticketAdd.txtRequestorID.Text = reader1["ID"].ToString();
                    _frmticketAdd.txtRequestorName.Text = reader1["FirstName"].ToString() + " " + reader1["LastName"].ToString();
                    _frmticketAdd.txtEmail.Text = reader1["Emailaddress"].ToString();
                    _frmticketAdd.txtContact.Text = reader1["contactnumber"].ToString();

                    reader1.Close();
                }
                else
                {
                    MessageBox.Show("No requestor information found. Please try again.");
                    _frmticketAdd.Close();
                }



            } catch (Exception ex)
            {
                MessageBox.Show("Error loading requestor's information. Please try again.\n\n" + ex.Message);
                _frmticketAdd.Close();
            }
        }

        //for view/edit form
        internal static void LoadRequestorInfoView(frmTicketView _frmTicketViewUser, string UID)
        {
            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "SELECT * FROM tblusers WHERE ID = @UserID";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", UID);
                reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        _frmTicketViewUser.txtRequestorID.Text = reader1["ID"].ToString();
                        _frmTicketViewUser.txtRequestorName.Text = reader1["FirstName"].ToString() + " " + reader1["LastName"].ToString();
                        _frmTicketViewUser.txtEmail.Text = reader1["Emailaddress"].ToString();
                        _frmTicketViewUser.txtContact.Text = reader1["contactnumber"].ToString();
                    }
                    reader1.Close();
                }
                else
                {
                    MessageBox.Show("Unable to load requestor information. Please try again.");
                    _frmTicketViewUser.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading requestor's information. Please try again.\n\n" + ex.Message);
                _frmTicketViewUser.Close();
            }
        }

        //pang combo box selection ng categories
        internal static void LoadCategories(frmTicketAdd _frmticketAdd)
        {
            try
            {
                string query = "SELECT * FROM tblcategories WHERE Status = 'Active'";
                cmd = new SqlCommand(query, conn);
                reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        _frmticketAdd.cmbTicketCategory.Items.Add(reader1["CategoryName"].ToString());
                    }
                    reader1.Close();
                }
                else
                {
                    MessageBox.Show("No requestor information found. Please try again.");
                    _frmticketAdd.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading category list. Please try again.\n\n" + ex.Message);
                _frmticketAdd.Close();
            }
        }

        //variable/string pang set ng priority level
        internal static string _priorityLevel(frmTicketAdd _frmnewticket)
        {
            try
            {
                string prio = "";
                //read from tblcategories
                DatabaseHelper.ConnCloseOpen();
                string query = "SELECT * FROM tblcategories WHERE CategoryName = @category";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@category", _frmnewticket.cmbTicketCategory.Text);
                reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        if (reader1["PriorityLevel"].ToString().ToLower() == "high")
                        {
                            prio = "high";
                        }
                        else if (reader1["PriorityLevel"].ToString().ToLower() == "medium")
                        {
                            prio = "medium";
                        }
                        else if (reader1["PriorityLevel"].ToString().ToLower() == "low")
                        {
                            prio = "low";
                        }
                    }
                    reader1.Close();


                }
                else
                {
                    MessageBox.Show("Category entered is invalid. Please select from the drop down list.");
                }

                return prio;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading priority level. Please select a valid category again.\n\n" + ex.Message);
                return "";

            }

        }

        //pang save ng new ticket
        internal static void AddNewTicket(frmTicketAdd _frmticketAdd)
        {
            DatabaseHelper.ConnCloseOpen();

            string prio = _priorityLevel(_frmticketAdd);

            if (prio == "")
            {
                //to prevent from continuing if did not find matching category:
                return;
            }

            try
            {

                string query = "INSERT INTO tblTicketsList (Status, Category, PriorityLevel, Title, Description, RequestorID, DateCreated, LastModifiedDateTime, LastModifiedbyID) VALUES (@status, @category, @prioritylevel, @title, @description , @requestorid, @datecreated, @lastmodifieddatetime, @lastmodifiedbyid)";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", "New");
                cmd.Parameters.AddWithValue("@category", _frmticketAdd.cmbTicketCategory.Text);
                cmd.Parameters.AddWithValue("@prioritylevel", prio);
                cmd.Parameters.AddWithValue("@title", _frmticketAdd.txtTitle.Text);
                cmd.Parameters.AddWithValue("@description", _frmticketAdd.txtDescription.Text);
                cmd.Parameters.AddWithValue("@requestorid", _frmticketAdd.txtRequestorID.Text);
                cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastmodifieddatetime", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastmodifiedbyid", CurrentUser.userID);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Ticket added successfully.");
                    _frmticketAdd.Close();
                }
                else
                {
                    MessageBox.Show("Error adding ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding ticket. Please try again.\n\n" + ex.Message);
            }
        }

        //gamit ko sa combobox Priority Level and Ticket Status
        //load ng data
        internal static void LoadTickets_homepage(frmHomePage _HomePageUser)
        {
            //clear datagridview
            _HomePageUser.dgvTickets.Rows.Clear();

            _HomePageUser.txtsearch.Text = "";


            //initial load of count
            Ticket.CountTickets(_HomePageUser);



            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "";

                //check filter status
                if (_HomePageUser.cmbFilterStatus.SelectedIndex == 0)
                {
                    //check if user is admin or not
                    if (CurrentUser.UserType.ToLower() != "admin")
                    {
                        //user
                        query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID WHERE t.RequestorID = @RequestorID AND (t.Status = 'New' OR t.Status='In progress' OR t.Status='Pending') ORDER BY LastModifiedDateTime ASC";
                    }
                    else if (CurrentUser.UserType.ToLower() == "admin" && _HomePageUser.cmbPriorityLevel.SelectedIndex == 0)
                    {
                        //admin
                        //load all
                        query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID  WHERE t.Status = 'New' OR t.Status='In progress' ORDER BY LastModifiedDateTime ASC";
                    }
                    else
                    {
                        query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID WHERE prioritylevel  = @prioritylevel AND (t.Status = 'New' OR t.Status='In progress') ORDER BY LastModifiedDateTime ASC";
                    }
                }
                else if (_HomePageUser.cmbFilterStatus.SelectedIndex != 0)
                {
                    //check if user is admin or not
                    if (CurrentUser.UserType.ToLower() != "admin")
                    {
                        //user
                        query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID WHERE t.RequestorID = @RequestorID AND t.Status = @ticketstatus ORDER BY LastModifiedDateTime ASC";
                    }
                    else if (CurrentUser.UserType.ToLower() == "admin" && _HomePageUser.cmbPriorityLevel.SelectedIndex == 0)
                    {
                        //admin
                        //load all
                        query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID  WHERE t.Status = @ticketstatus ORDER BY LastModifiedDateTime ASC";
                    }
                    else
                    {
                        query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID WHERE prioritylevel  = @prioritylevel AND t.Status = @ticketstatus ORDER BY LastModifiedDateTime ASC";
                    }
                }





                cmd = new SqlCommand(query, conn);



                if (CurrentUser.UserType.ToLower() != "admin")
                {
                    cmd.Parameters.AddWithValue("@RequestorID", CurrentUser.userID);
                }
                else if (CurrentUser.UserType.ToLower() == "admin" && _HomePageUser.cmbPriorityLevel.SelectedIndex != 0)
                {
                    cmd.Parameters.AddWithValue("@prioritylevel", _HomePageUser.cmbPriorityLevel.Text);
                }


                if (_HomePageUser.cmbFilterStatus.SelectedIndex != 0)
                {
                    cmd.Parameters.AddWithValue("@ticketstatus", _HomePageUser.cmbFilterStatus.Text);
                }



                reader1 = cmd.ExecuteReader();


                if (reader1.HasRows)
                {


                    while (reader1.Read())
                    {
                        //add to datagridview

                        _HomePageUser.dgvTickets.Rows.Add(reader1["Id"].ToString(), reader1["PriorityLevel"].ToString(), reader1["Status"].ToString(), reader1["Title"].ToString(), reader1["firstname"].ToString() + " " + reader1["lastname"].ToString(), reader1["LastModifiedDateTime"].ToString());

                    }


                    reader1.Close();


                }
                else
                {
                    _HomePageUser.dgvTickets.Rows.Clear();
                }

                _HomePageUser.dgvTickets.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tickets. Please try again.\n\n" + ex.Message);
            }
        }

        //edi pang search . duh
        internal static void SearchTicket_homepage(frmHomePage _HomePage, string _keywordsearch)
        {
            //clear datagridview
            _HomePage.dgvTickets.Rows.Clear();

            if (_HomePage.txtsearch.Text != "")
            {
                _HomePage.cmbFilterStatus.Enabled = false;
                _HomePage.cmbPriorityLevel.Enabled = false;
            }
            else
            {
                _HomePage.cmbFilterStatus.Enabled = true;
                _HomePage.cmbPriorityLevel.Enabled = true;

                //reload data as is
                Ticket.LoadTickets_homepage(_HomePage);
                return;
            }


            //search na dito
            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "";


                //check if user is admin or not
                if (CurrentUser.UserType.ToLower() != "admin")
                {
                    //user
                    query = query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t " +
                                "JOIN tblUsers u ON t.RequestorID = u.ID " +
                                "WHERE t.RequestorID = @RequestorID " +
                                "AND (t.category LIKE CONCAT('%', @keyword, '%') " +
                                "OR t.title LIKE CONCAT('%', @keyword, '%') " +
                                "OR t.description LIKE CONCAT('%', @keyword, '%') " +
                                "OR FORMAT(t.LastModifiedDateTime, 'MM/dd/yyyy') LIKE CONCAT('%', @keyword, '%') " +
                                "OR t.id LIKE CONCAT('%', @keyword, '%')) " +
                                "ORDER BY t.LastModifiedDateTime ASC";
                }
                else if (CurrentUser.UserType.ToLower() == "admin")
                {
                    //admin
                    //load all
                    query = query = "SELECT t.*, u.firstname, u.lastname FROM tblTicketsList t " +
                                "JOIN tblUsers u ON t.RequestorID = u.ID WHERE " +
                                "t.category LIKE CONCAT('%', @keyword, '%') " +
                                "OR t.title LIKE CONCAT('%', @keyword, '%') " +
                                "OR t.description LIKE CONCAT('%', @keyword, '%') " +
                                "OR FORMAT(t.LastModifiedDateTime, 'MM/dd/yyyy') LIKE CONCAT('%', @keyword, '%') " +
                                "OR t.id LIKE CONCAT('%', @keyword, '%') " +
                                "ORDER BY t.LastModifiedDateTime ASC";
                }
                //AND (t.category LIKE concat('%',@keyword,'%') OR t.title LIKE concat('%',@keyword,'%') OR t.description LIKE concat('%',@keyword,'%'))


                cmd = new SqlCommand(query, conn);



                if (CurrentUser.UserType.ToLower() != "admin")
                {
                    cmd.Parameters.AddWithValue("@RequestorID", CurrentUser.userID);
                }


                cmd.Parameters.AddWithValue("@keyword", _keywordsearch);


                reader1 = cmd.ExecuteReader();


                if (reader1.HasRows)
                {


                    while (reader1.Read())
                    {
                        //add to datagridview

                        _HomePage.dgvTickets.Rows.Add(reader1["Id"].ToString(), reader1["PriorityLevel"].ToString(), reader1["Status"].ToString(), reader1["Title"].ToString(), reader1["firstname"].ToString() + " " + reader1["lastname"].ToString(), reader1["LastModifiedDateTime"].ToString());

                    }


                    reader1.Close();


                }
                else
                {
                    _HomePage.dgvTickets.Rows.Clear();
                }

                _HomePage.dgvTickets.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tickets. Please try again.\n\n" + ex.Message);
            }
        }

        //opening the ticket information on to the form
        internal static void ViewTicketDeets(frmTicketView _frmticketview, string _ticketNum)
        {
            _ticketNum = Ticket.CurrentTicketID;
            try
            {

                DatabaseHelper.ConnCloseOpen();
                string query = "SELECT t.*, u.ID AS userID, u.FirstName, u.LastName, u.Emailaddress, u.ContactNumber, u.status as userStatus FROM tblTicketsList t JOIN tblUsers u ON t.RequestorID = u.ID WHERE t.ID = @ticketID";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticketID", _ticketNum);
                reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        _frmticketview.txtTicketNum.Text = reader1["ID"].ToString();
                        _frmticketview.txtTitle.Text = reader1["Title"].ToString();
                        _frmticketview.txtDescription.Text = reader1["Description"].ToString();
                        _frmticketview.txtTicketCategory.Text = reader1["Category"].ToString();
                        _frmticketview.txtPriority.Text = textInfo.ToTitleCase(reader1["PriorityLevel"].ToString());
                        _frmticketview.txtTicketStatus.Text = reader1["Status"].ToString();
                        //
                        //set ticket status while loading
                        Ticket_Status = reader1["Status"].ToString();
                        //
                        _frmticketview.txtRequestorID.Text = reader1["RequestorID"].ToString();
                        _frmticketview.txtRequestorName.Text = reader1["FirstName"].ToString() + " " + reader1["LastName"].ToString();
                        _frmticketview.txtEmail.Text = reader1["Emailaddress"].ToString();
                        _frmticketview.txtContact.Text = reader1["contactnumber"].ToString();
                        _frmticketview.txtDateCreated.Text = reader1["DateCreated"].ToString();
                        _frmticketview.txtLastModified.Text = reader1["LastModifiedDateTime"].ToString();
                    }

                    CheckTicketStatus(_frmticketview);
                }
                else
                {
                    MessageBox.Show("Unable to read ticket information. Please try again.");
                    _frmticketview.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load ticket information. Please try again.\n\n" + ex.Message);
            }
        }

        //load notes sa ticket view
        internal static void LoadNotes(frmTicketView _frmticketNoteLoad, string _ticketnum)
        {
            _frmticketNoteLoad.dgvNotes.RowHeadersVisible = false;
            _frmticketNoteLoad.dgvNotes.Rows.Clear();
            _frmticketNoteLoad.dgvNotes.ClearSelection();

            _ticketnum = Ticket.CurrentTicketID;

            try
            {
                DatabaseHelper.ConnCloseOpen();
                string query = "SELECT t.*, u.* FROM tblTicketNotes t JOIN tblUsers u ON t.NotedbyID = u.ID WHERE t.TicketID = @ticketID ORDER BY DateAdded DESC";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticketID", _ticketnum);
                reader1 = cmd.ExecuteReader();
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        _frmticketNoteLoad.dgvNotes.Rows.Add(reader1["DateAdded"].ToString(), reader1["FirstName"].ToString() + " " + reader1["LastName"].ToString(), reader1["TicketNotes"].ToString());
                    }
                    reader1.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ticket notes. Please try again.\n\n" + ex.Message);
            }
        }

        //reselect ng row sa home page
        internal static void ReselectRow(frmHomePage _userHome)
        {
            if (_userHome.dgvTickets.RowCount == 0)
            {
                return;
            }
            else
            {
                //reselect 'yung data row
                _userHome.dgvTickets.CurrentCell = _userHome.dgvTickets.Rows[selectedRowIndex].Cells[0];
            }
        }

        //add ng note sa ticket
        internal static void AddNotes(frmTicketView _frmaddnote, string _ticketno, string _newNote)
        {
            _ticketno = Ticket.CurrentTicketID;

            try
            {
                DatabaseHelper.ConnCloseOpen();
                string query = "INSERT INTO tblTicketNotes (TicketID, DateAdded, NotedbyID, TicketNotes) VALUES (@ticketID, @dateadded, @notedbyID,  @ticketnotes)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticketID", _ticketno);
                cmd.Parameters.AddWithValue("@ticketnotes", _newNote);
                cmd.Parameters.AddWithValue("@notedbyID", CurrentUser.userID);
                cmd.Parameters.AddWithValue("@dateadded", DateTime.Now);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    _frmaddnote.lblAddNoteSuccess.Visible = true;
                    _frmaddnote.tmrNoteSuccess.Enabled = true;
                    hasAddedNotes = true;
                }
                else
                {
                    MessageBox.Show("Error adding note. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding note. Please try again.\n\n" + ex.Message);
                return;
            }
        }

        //pang update ng status ng ticket
        //depende sa pinindot ng user
        internal static void UpdateStatus(frmTicketView _tview, int selectedAction)
        {

            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "UPDATE tblTicketsList SET Status = @status, LastModifiedDateTime = @lastmodifieddatetime, LastModifiedbyID = @lastmodifiedbyid WHERE ID = @ticketID";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ticketID", Ticket.CurrentTicketID);
                cmd.Parameters.AddWithValue("@lastmodifieddatetime", DateTime.Now);
                cmd.Parameters.AddWithValue("@lastmodifiedbyid", CurrentUser.userID);

                //check which action was selected
                //status
                switch (selectedAction)
                {
                    case 1:
                        cmd.Parameters.AddWithValue("@status", "In Progress");
                        break;
                    case 2:
                        cmd.Parameters.AddWithValue("@status", "Cancelled");
                        break;
                    case 3:
                        cmd.Parameters.AddWithValue("@status", "Pending");
                        break;
                    case 4:
                        cmd.Parameters.AddWithValue("@status", "Closed");
                        break;
                }

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Ticket status updated successfully.");
                    _tview.Close();
                    hasAddedNotes = false;

                    switch (selectedAction)
                    {
                        case 1:
                            Ticket.AddNotes(_tview, Ticket.CurrentTicketID, "System: Requestor re-sent the ticket to Admin.");
                            break;
                        case 2:
                            Ticket.AddNotes(_tview, Ticket.CurrentTicketID, "System: Requestor Cancelled the ticket.");
                            break;
                        case 3:
                            Ticket.AddNotes(_tview, Ticket.CurrentTicketID, "System: Admin returned the ticket to requestor.");
                            break;
                        case 4:
                            Ticket.AddNotes(_tview, Ticket.CurrentTicketID, "System: Admin marked the ticket as Closed/Resolved");
                            break;
                    }

                    //reset notes adding status
                    hasAddedNotes = false;



                    //Next"
                    //reload the ticket info to show the status
                    //reload the ticket notes


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ticket status. Please try again.\n\n" + ex.Message);
            }


        }

        //pang set BUTTONS depende sa status ng ticket
        internal static void CheckTicketStatus(frmTicketView _ticktview)
        {
            if (CurrentUser.UserType.ToLower() == "admin")
            {
                _ticktview.btnInProgress.Visible = false;
                _ticktview.btnCancel.Visible = false;



                if (Ticket_Status == "Pending")
                {
                    _ticktview.btnPending.Enabled = false;
                    _ticktview.btnClose.Enabled = true;
                }
                else if (Ticket_Status == "Closed" || Ticket_Status == "Cancelled")
                {
                    _ticktview.btnPending.Visible = false;
                    _ticktview.btnClose.Visible = false;
                    _ticktview.btnAddNote.Enabled = false;
                }
            }
            else
            {
                //user

                _ticktview.btnPending.Visible = false;
                _ticktview.btnClose.Visible = false;

                if (Ticket_Status == "New")
                {
                    _ticktview.btnInProgress.Enabled = false;
                }
                else if (Ticket_Status == "In Progress")
                {
                    _ticktview.btnInProgress.Enabled = false;
                }
                else if (Ticket_Status == "Pending")
                {
                    _ticktview.btnInProgress.Enabled = true;
                }
                else if (Ticket_Status == "Closed" || Ticket_Status == "Cancelled")
                {
                    _ticktview.btnInProgress.Visible = false;
                    _ticktview.btnCancel.Visible = false;
                    _ticktview.btnAddNote.Enabled = false;
                }
            }
        }

        //pang bilang ng ticket sa home page
        internal static void CountTickets(frmHomePage _homeP)
        {
            DatabaseHelper.ConnCloseOpen();


            try
            {
                DatabaseHelper.ConnCloseOpen();

                string query = "";


                //check if user is admin or not
                if (CurrentUser.UserType.ToLower() != "admin")
                {
                    //user
                    query = "SELECT * FROM tblTicketsList WHERE RequestorID = @RequestorID";
                }
                else if (CurrentUser.UserType.ToLower() == "admin")
                {
                    //admin
                    //load all
                    query = "SELECT * FROM tblTicketsList WHERE Status='new' OR Status='in progress' OR Status='pending'";
                }
                

                cmd = new SqlCommand(query, conn);

                //add parameter if non-admin
                if (CurrentUser.UserType.ToLower() != "admin")
                {
                    cmd.Parameters.AddWithValue("@RequestorID", CurrentUser.userID);
                }

                reader1 = cmd.ExecuteReader();

                //reset values to zero
                CountNew = 0;
                CountInProgress= 0;
                CountPending = 0;
                CountHigh = 0;
                CountMedium = 0;
                CountLow = 0;


                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        //Count ticket count based on status
                        if (reader1["Status"].ToString().ToLower() == "new") { Ticket.CountNew++; }
                        else if (reader1["Status"].ToString().ToLower() == "in progress") { Ticket.CountInProgress++; }
                        else if (reader1["Status"].ToString().ToLower() == "pending") { Ticket.CountPending++; }

                        //count ticket count based on priority level
                        if (reader1["PriorityLevel"].ToString().ToLower() == "high") { Ticket.CountHigh++; }
                        else if (reader1["PriorityLevel"].ToString().ToLower() == "medium") { Ticket.CountMedium++; }
                        else if (reader1["PriorityLevel"].ToString().ToLower() == "low") { Ticket.CountLow++; }

                    }

                    _homeP.lblCountNew.Text = Ticket.CountNew.ToString();
                    _homeP.lblCountInProgress.Text = Ticket.CountInProgress.ToString();
                    _homeP.lblCountPending.Text = Ticket.CountPending.ToString();

                    _homeP.lblCountHigh.Text = Ticket.CountHigh.ToString(); 
                    _homeP.lblCountMedium.Text = Ticket.CountMedium.ToString();   
                    _homeP.lblCountLow.Text = Ticket.CountLow.ToString();



                    reader1.Close();


                }
            }
            catch (Exception ex ){
                //do nothing here for now

            }
        }


    }
}
