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
    public partial class frmCategories : Form
    {
        




        public frmCategories()
        {
            InitializeComponent();
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            grpAddCategory.Visible = false;
            dgvCategories.Enabled = true;   

        }

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            grpAddCategory.Visible = true;
            grpEdit.Visible = false;
            dgvCategories.Enabled = false;

            txtAddCategoryName.Focus();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            Categories.LoadCategories(this);
            dgvCategories.ClearSelection();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            Categories.addCategory(this);
        }

        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvCategories.RowCount != 0 )
            {
                try
                {
                    txtAddCategoryName.Focus();

                    //set kung ano ang selected row
                    Categories.selectedRowIndex = e.RowIndex;

                    //set the curremt selection
                    Categories.CategoryID = dgvCategories.SelectedCells[0].Value.ToString();


                    //show the data

                    txtUpdateCategoryName.Text = dgvCategories.SelectedCells[1].Value.ToString();
                    txtUpdateDescription.Text = dgvCategories.SelectedCells[2].Value.ToString();
                    cmbUpdatePriorityLevel.Text = dgvCategories.SelectedCells[3].Value.ToString();
                    cmbUpdateStatus.Text = dgvCategories.SelectedCells[4].Value.ToString();

                    grpEdit.Visible = true;

                    grpAddCategory.Visible = false;
                    dgvCategories.Enabled = false;
                }
                catch {
                    //do nothing
                }

            }
            else
            {
                MessageBox.Show("There's no existing Category to edit.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            Categories.LoadCategories(this);

            grpEdit.Visible = false;
            txtUpdateCategoryName.Clear();
            txtUpdateDescription.Clear();
            cmbUpdatePriorityLevel.Text = "";
            cmbUpdateStatus.Text = "";

            dgvCategories.Enabled = true;

            
            
            //OOP
            //
            Categories.ReselectRow(this);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //OOP
            //update data
            Categories.UpdateCategory(this);

            //OOP
            //refresh dta grid
            Categories.LoadCategories(this);

            //OOP
            //
            Categories.ReselectRow(this);


            dgvCategories.Enabled = true;

        }
    }
}
