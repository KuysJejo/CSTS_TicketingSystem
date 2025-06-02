using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;
using Microsoft.IdentityModel.Protocols;

namespace TicketingSystem
{
    internal class Categories
    {


        //START OF SQL connection CODE ko

        private static readonly SqlConnection conn = DatabaseHelper.GetConnection();
        private static SqlCommand cmd = null;
        private static SqlDataReader reader = null;

        //END OF SQL connection CODE ko



        internal static string CategoryID { get; set; }

        private static string CategoryName { get; set; }

        private static string PriorityLevel { get; set; }

        private static string CategoryDescription { get; set; }

        private static string CategoryStatus { get; set; }

        private static string LastModifiedBy { get; set; }



        internal static int selectedRowIndex=-1;


        //pang-add
        internal static void addCategory(frmCategories categoryForm)
        {

            //check if the fields are empty
            if (categoryForm.txtAddCategoryName.Text == "" || categoryForm.txtAddDescription.Text == "" || categoryForm.cmbAddPriorityLevel.Text == "")
                MessageBox.Show("Please fill in all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                string query = "INSERT INTO tblCategories (CategoryName, Description, PriorityLevel, Status, LastModifiedBy) VALUES (@CategoryName, @Description, @PriorityLevel, @CategoryStatus, @LastModifiedby)";

                DatabaseHelper.ConnCloseOpen();

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CategoryName", categoryForm.txtAddCategoryName.Text);
                cmd.Parameters.AddWithValue("@Description", categoryForm.txtAddDescription.Text);
                cmd.Parameters.AddWithValue("@PriorityLevel", categoryForm.cmbAddPriorityLevel.Text);
                cmd.Parameters.AddWithValue("@CategoryStatus", "Active");
                cmd.Parameters.AddWithValue("@LastModifiedBy", CurrentUser.FirstName + " " + CurrentUser.LastName);

                int rowsAffected = cmd.ExecuteNonQuery();

                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    categoryForm.grpAddCategory.Visible = false;
                    categoryForm.txtAddCategoryName.Clear();
                    categoryForm.txtAddDescription.Clear();
                    categoryForm.cmbAddPriorityLevel.Text = "";

                }
                else
                {
                    MessageBox.Show("Failed to add category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        //pang-load sa dgv
        internal static void LoadCategories(frmCategories categoryForm)
        {

            categoryForm.dgvCategories.Rows.Clear();  
            categoryForm.dgvCategories.Refresh();
            categoryForm.dgvCategories.MultiSelect = false;
            categoryForm.dgvCategories.RowHeadersVisible = false;
            try {
                string query = "SELECT * FROM tblCategories";
                DatabaseHelper.ConnCloseOpen();

                cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //load the categories into the datagridview
                        CategoryID = reader["ID"].ToString();
                        CategoryName = reader["CategoryName"].ToString();
                        CategoryDescription = reader["Description"].ToString();
                        PriorityLevel = reader["PriorityLevel"].ToString();
                        CategoryStatus = reader["Status"].ToString();
                        LastModifiedBy = reader["LastModifiedBy"].ToString();

                        //add to the datagridview
                        categoryForm.dgvCategories.Rows.Add(CategoryID, CategoryName, CategoryDescription, PriorityLevel, CategoryStatus, LastModifiedBy);
                    }
                }
                else
                {
                    MessageBox.Show("No categories found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        //pang update
        internal static void UpdateCategory(frmCategories categoryForm)
        {
            string query = "UPDATE tblCategories SET CategoryName = @CategoryName, Description = @Description, PriorityLevel = @PriorityLevel, Status = @CategoryStatus, LastModifiedBy = @LastModifiedBy WHERE ID = @ID";
            DatabaseHelper.ConnCloseOpen();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CategoryName", categoryForm.txtUpdateCategoryName.Text);
            cmd.Parameters.AddWithValue("@Description", categoryForm.txtUpdateDescription.Text);
            cmd.Parameters.AddWithValue("@PriorityLevel", categoryForm.cmbUpdatePriorityLevel.Text);
            cmd.Parameters.AddWithValue("@CategoryStatus", categoryForm.cmbUpdateStatus.Text);
            cmd.Parameters.AddWithValue("@LastModifiedBy", CurrentUser.FirstName + " " + CurrentUser.LastName);
            cmd.Parameters.AddWithValue("@ID", Categories.CategoryID);
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Category updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                categoryForm.grpEdit.Visible = false;
                categoryForm.txtUpdateCategoryName.Clear();
                categoryForm.txtUpdateDescription.Clear();
                categoryForm.cmbUpdatePriorityLevel.Text = "";
                categoryForm.cmbUpdateStatus.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to update category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        //reset sa dgv
        internal static void ReselectRow(frmCategories categoryForm)
        {

            //reselect 'yung data row
            categoryForm.dgvCategories.CurrentCell = categoryForm.dgvCategories.Rows[selectedRowIndex].Cells[0];

        }
    }
}
