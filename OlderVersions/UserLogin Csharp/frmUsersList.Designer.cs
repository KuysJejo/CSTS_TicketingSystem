namespace TicketingSystem
{
    partial class frmUsersList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsersList = new System.Windows.Forms.DataGridView();
            this._UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkSearchOption = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._UID,
            this._UserName,
            this._Status,
            this._Role,
            this._FirstName,
            this._LastName,
            this._Email,
            this._ContactNo});
            this.dgvUsersList.Location = new System.Drawing.Point(12, 124);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersList.Size = new System.Drawing.Size(1138, 294);
            this.dgvUsersList.TabIndex = 4;
            this.dgvUsersList.TabStop = false;
            this.dgvUsersList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersList_CellContentDoubleClick);
            // 
            // _UID
            // 
            dataGridViewCellStyle8.NullValue = null;
            this._UID.DefaultCellStyle = dataGridViewCellStyle8;
            this._UID.HeaderText = "ID";
            this._UID.Name = "_UID";
            this._UID.ReadOnly = true;
            this._UID.Width = 50;
            // 
            // _UserName
            // 
            this._UserName.HeaderText = "User Name";
            this._UserName.Name = "_UserName";
            this._UserName.ReadOnly = true;
            this._UserName.Width = 200;
            // 
            // _Status
            // 
            this._Status.HeaderText = "Status";
            this._Status.Name = "_Status";
            this._Status.ReadOnly = true;
            // 
            // _Role
            // 
            this._Role.HeaderText = "Role";
            this._Role.Name = "_Role";
            this._Role.ReadOnly = true;
            // 
            // _FirstName
            // 
            this._FirstName.HeaderText = "First Name";
            this._FirstName.Name = "_FirstName";
            this._FirstName.ReadOnly = true;
            this._FirstName.Width = 150;
            // 
            // _LastName
            // 
            this._LastName.HeaderText = "Last Name";
            this._LastName.Name = "_LastName";
            this._LastName.ReadOnly = true;
            this._LastName.Width = 150;
            // 
            // _Email
            // 
            this._Email.HeaderText = "Email Address";
            this._Email.Name = "_Email";
            this._Email.ReadOnly = true;
            this._Email.Width = 150;
            // 
            // _ContactNo
            // 
            this._ContactNo.HeaderText = "Contact Number";
            this._ContactNo.Name = "_ContactNo";
            this._ContactNo.ReadOnly = true;
            this._ContactNo.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(923, 89);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(227, 29);
            this.btnAddNewUser.TabIndex = 3;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Keyword:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(923, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // chkSearchOption
            // 
            this.chkSearchOption.AutoSize = true;
            this.chkSearchOption.Checked = true;
            this.chkSearchOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSearchOption.Location = new System.Drawing.Point(923, 55);
            this.chkSearchOption.Name = "chkSearchOption";
            this.chkSearchOption.Size = new System.Drawing.Size(162, 17);
            this.chkSearchOption.TabIndex = 2;
            this.chkSearchOption.Text = "Search non-admin users only";
            this.chkSearchOption.UseVisualStyleBackColor = true;
            this.chkSearchOption.CheckedChanged += new System.EventHandler(this.chkSearchOption_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkSearchOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 83);
            this.panel1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 17);
            this.toolStripStatusLabel1.Text = "No of Records: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "frmUsersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users List";
            this.Load += new System.EventHandler(this.frmUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        internal System.Windows.Forms.DataGridView dgvUsersList;

        private System.Windows.Forms.DataGridViewTextBoxColumn _UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn _FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ContactNo;

        internal System.Windows.Forms.CheckBox chkSearchOption;
        internal System.Windows.Forms.TextBox txtSearch;

    }
}