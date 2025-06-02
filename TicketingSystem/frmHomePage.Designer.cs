namespace TicketingSystem
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btbCatMgt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserMgt = new System.Windows.Forms.Button();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.TicketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastModifiedDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCountPending = new System.Windows.Forms.Label();
            this.lblCountInProgress = new System.Windows.Forms.Label();
            this.lblCountNew = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.cmbPriorityLevel = new System.Windows.Forms.ComboBox();
            this.grpsearch = new System.Windows.Forms.GroupBox();
            this.tmrCountTickets = new System.Windows.Forms.Timer(this.components);
            this.strCountPriority = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountHigh = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountMedium = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCountLow = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.CMS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpsearch.SuspendLayout();
            this.strCountPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btbCatMgt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUserMgt);
            this.panel1.Controls.Add(this.lblWelcomeName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMyProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 82);
            this.panel1.TabIndex = 0;
            // 
            // btbCatMgt
            // 
            this.btbCatMgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btbCatMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCatMgt.Location = new System.Drawing.Point(651, 15);
            this.btbCatMgt.Margin = new System.Windows.Forms.Padding(4);
            this.btbCatMgt.Name = "btbCatMgt";
            this.btbCatMgt.Size = new System.Drawing.Size(117, 47);
            this.btbCatMgt.TabIndex = 4;
            this.btbCatMgt.Text = "Category Management";
            this.btbCatMgt.UseVisualStyleBackColor = true;
            this.btbCatMgt.Click += new System.EventHandler(this.btbCatMgt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserMgt
            // 
            this.btnUserMgt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserMgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserMgt.Location = new System.Drawing.Point(776, 15);
            this.btnUserMgt.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserMgt.Name = "btnUserMgt";
            this.btnUserMgt.Size = new System.Drawing.Size(117, 47);
            this.btnUserMgt.TabIndex = 5;
            this.btnUserMgt.Text = "User Management";
            this.btnUserMgt.UseVisualStyleBackColor = true;
            this.btnUserMgt.Click += new System.EventHandler(this.btnUserMgt_Click);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.Location = new System.Drawing.Point(154, 37);
            this.lblWelcomeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(177, 25);
            this.lblWelcomeName.TabIndex = 1;
            this.lblWelcomeName.Text = "Welcome USER";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1026, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(117, 47);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.Location = new System.Drawing.Point(901, 15);
            this.btnMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(117, 47);
            this.btnMyProfile.TabIndex = 6;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTicket.Location = new System.Drawing.Point(583, 99);
            this.btnNewTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(117, 57);
            this.btnNewTicket.TabIndex = 0;
            this.btnNewTicket.Text = "Create New Ticket";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTickets.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketID,
            this.PriorityLevel,
            this.Status,
            this.Title,
            this.RequestorID,
            this.LastModifiedDateTime});
            this.dgvTickets.ContextMenuStrip = this.CMS;
            this.dgvTickets.Location = new System.Drawing.Point(155, 164);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTickets.MultiSelect = false;
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(992, 367);
            this.dgvTickets.TabIndex = 11;
            this.dgvTickets.TabStop = false;
            this.dgvTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellClick);
            this.dgvTickets.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentDoubleClick);
            // 
            // TicketID
            // 
            this.TicketID.HeaderText = "Ticket ID";
            this.TicketID.Name = "TicketID";
            this.TicketID.ReadOnly = true;
            this.TicketID.Width = 70;
            // 
            // PriorityLevel
            // 
            this.PriorityLevel.HeaderText = "Priority Level";
            this.PriorityLevel.Name = "PriorityLevel";
            this.PriorityLevel.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // RequestorID
            // 
            this.RequestorID.HeaderText = "Requested by";
            this.RequestorID.Name = "RequestorID";
            this.RequestorID.ReadOnly = true;
            this.RequestorID.Width = 200;
            // 
            // LastModifiedDateTime
            // 
            this.LastModifiedDateTime.HeaderText = "Last Modified";
            this.LastModifiedDateTime.Name = "LastModifiedDateTime";
            this.LastModifiedDateTime.ReadOnly = true;
            this.LastModifiedDateTime.Width = 150;
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOpenItem});
            this.CMS.Name = "cmsOpenItem";
            this.CMS.Size = new System.Drawing.Size(178, 26);
            this.CMS.Text = "Open Item";
            // 
            // cmsOpenItem
            // 
            this.cmsOpenItem.Name = "cmsOpenItem";
            this.cmsOpenItem.Size = new System.Drawing.Size(177, 22);
            this.cmsOpenItem.Text = "Open Selected Item";
            this.cmsOpenItem.Click += new System.EventHandler(this.cmsOpenItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter by Status:";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "(Active Only)",
            "New",
            "Pending",
            "In Progress",
            "Closed",
            "Cancelled"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(157, 132);
            this.cmbFilterStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(224, 24);
            this.cmbFilterStatus.TabIndex = 2;
            this.cmbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFilterStatus_SelectedIndexChanged);
            this.cmbFilterStatus.TextChanged += new System.EventHandler(this.cmbFilterStatus_TextChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Location = new System.Drawing.Point(51, 21);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(381, 22);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCountPending);
            this.panel2.Controls.Add(this.lblCountInProgress);
            this.panel2.Controls.Add(this.lblCountNew);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 493);
            this.panel2.TabIndex = 10;
            // 
            // lblCountPending
            // 
            this.lblCountPending.AutoSize = true;
            this.lblCountPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPending.Location = new System.Drawing.Point(50, 191);
            this.lblCountPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountPending.Name = "lblCountPending";
            this.lblCountPending.Size = new System.Drawing.Size(40, 42);
            this.lblCountPending.TabIndex = 17;
            this.lblCountPending.Text = "0";
            // 
            // lblCountInProgress
            // 
            this.lblCountInProgress.AutoSize = true;
            this.lblCountInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountInProgress.Location = new System.Drawing.Point(50, 117);
            this.lblCountInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountInProgress.Name = "lblCountInProgress";
            this.lblCountInProgress.Size = new System.Drawing.Size(40, 42);
            this.lblCountInProgress.TabIndex = 15;
            this.lblCountInProgress.Text = "0";
            // 
            // lblCountNew
            // 
            this.lblCountNew.AutoSize = true;
            this.lblCountNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountNew.Location = new System.Drawing.Point(50, 43);
            this.lblCountNew.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountNew.Name = "lblCountNew";
            this.lblCountNew.Size = new System.Drawing.Size(40, 42);
            this.lblCountNew.TabIndex = 13;
            this.lblCountNew.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Returned/Pending:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "In Progress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Tickets:";
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Location = new System.Drawing.Point(390, 107);
            this.lblUrgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(61, 16);
            this.lblUrgency.TabIndex = 7;
            this.lblUrgency.Text = "Urgency:";
            // 
            // cmbPriorityLevel
            // 
            this.cmbPriorityLevel.FormattingEnabled = true;
            this.cmbPriorityLevel.Items.AddRange(new object[] {
            "All",
            "High",
            "Medium",
            "Low"});
            this.cmbPriorityLevel.Location = new System.Drawing.Point(390, 132);
            this.cmbPriorityLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPriorityLevel.Name = "cmbPriorityLevel";
            this.cmbPriorityLevel.Size = new System.Drawing.Size(185, 24);
            this.cmbPriorityLevel.TabIndex = 3;
            this.cmbPriorityLevel.SelectedIndexChanged += new System.EventHandler(this.cmbPriorityLevel_SelectedIndexChanged);
            this.cmbPriorityLevel.TextChanged += new System.EventHandler(this.cmbPriorityLevel_TextChanged);
            // 
            // grpsearch
            // 
            this.grpsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpsearch.Controls.Add(this.txtsearch);
            this.grpsearch.Location = new System.Drawing.Point(708, 93);
            this.grpsearch.Margin = new System.Windows.Forms.Padding(4);
            this.grpsearch.Name = "grpsearch";
            this.grpsearch.Padding = new System.Windows.Forms.Padding(4);
            this.grpsearch.Size = new System.Drawing.Size(441, 63);
            this.grpsearch.TabIndex = 9;
            this.grpsearch.TabStop = false;
            this.grpsearch.Text = "Search by Ticket Info";
            // 
            // tmrCountTickets
            // 
            this.tmrCountTickets.Enabled = true;
            this.tmrCountTickets.Interval = 15000;
            this.tmrCountTickets.Tick += new System.EventHandler(this.tmrCountTickets_Tick);
            // 
            // strCountPriority
            // 
            this.strCountPriority.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lblCountHigh,
            this.toolStripStatusLabel4,
            this.lblCountMedium,
            this.toolStripStatusLabel6,
            this.lblCountLow});
            this.strCountPriority.Location = new System.Drawing.Point(147, 550);
            this.strCountPriority.Name = "strCountPriority";
            this.strCountPriority.Size = new System.Drawing.Size(1015, 25);
            this.strCountPriority.TabIndex = 12;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 20);
            this.toolStripStatusLabel1.Text = "Count per Priority Level:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabel2.Text = "High:";
            // 
            // lblCountHigh
            // 
            this.lblCountHigh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountHigh.Name = "lblCountHigh";
            this.lblCountHigh.Size = new System.Drawing.Size(18, 20);
            this.lblCountHigh.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel4.Text = "Medium:";
            // 
            // lblCountMedium
            // 
            this.lblCountMedium.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMedium.Name = "lblCountMedium";
            this.lblCountMedium.Size = new System.Drawing.Size(18, 20);
            this.lblCountMedium.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabel6.Text = "Low:";
            // 
            // lblCountLow
            // 
            this.lblCountLow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLow.Name = "lblCountLow";
            this.lblCountLow.Size = new System.Drawing.Size(18, 20);
            this.lblCountLow.Text = "0";
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 575);
            this.ControlBox = false;
            this.Controls.Add(this.strCountPriority);
            this.Controls.Add(this.btnNewTicket);
            this.Controls.Add(this.grpsearch);
            this.Controls.Add(this.lblUrgency);
            this.Controls.Add(this.cmbPriorityLevel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Activated += new System.EventHandler(this.frmHomePageUser_Activated);
            this.Load += new System.EventHandler(this.frmHomePageUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.CMS.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpsearch.ResumeLayout(false);
            this.grpsearch.PerformLayout();
            this.strCountPriority.ResumeLayout(false);
            this.strCountPriority.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastModifiedDateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lblCountPending;
        internal System.Windows.Forms.Label lblCountInProgress;
        internal System.Windows.Forms.Label lblCountNew;
        internal System.Windows.Forms.ComboBox cmbFilterStatus;
        internal System.Windows.Forms.TextBox txtsearch;
        internal System.Windows.Forms.Label lblUrgency;
        internal System.Windows.Forms.Button btnNewTicket;
        internal System.Windows.Forms.Label lblWelcomeName;
        internal System.Windows.Forms.DataGridView dgvTickets;
        internal System.Windows.Forms.Button btbCatMgt;
        internal System.Windows.Forms.Button btnUserMgt;
        internal System.Windows.Forms.ComboBox cmbPriorityLevel;
        public System.Windows.Forms.Timer tmrCountTickets;
        internal System.Windows.Forms.StatusStrip strCountPriority;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel lblCountHigh;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel lblCountMedium;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel lblCountLow;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem cmsOpenItem;
    }
}