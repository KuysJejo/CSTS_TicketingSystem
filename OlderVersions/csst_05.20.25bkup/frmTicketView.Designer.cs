namespace TicketingSystem
{
    partial class frmTicketView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketView));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.txtAddNote = new System.Windows.Forms.RichTextBox();
            this.txtLastModified = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtTicketNum = new System.Windows.Forms.TextBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRequestorID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRequestorName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtTicketStatus = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddNoteSuccess = new System.Windows.Forms.Label();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicketCategory = new System.Windows.Forms.TextBox();
            this.tmrNoteSuccess = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(295, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel Request";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.Location = new System.Drawing.Point(543, 36);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(80, 83);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // txtAddNote
            // 
            this.txtAddNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddNote.Location = new System.Drawing.Point(17, 36);
            this.txtAddNote.Name = "txtAddNote";
            this.txtAddNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtAddNote.Size = new System.Drawing.Size(520, 83);
            this.txtAddNote.TabIndex = 0;
            this.txtAddNote.Text = "";
            // 
            // txtLastModified
            // 
            this.txtLastModified.Location = new System.Drawing.Point(438, 444);
            this.txtLastModified.Name = "txtLastModified";
            this.txtLastModified.ReadOnly = true;
            this.txtLastModified.Size = new System.Drawing.Size(154, 20);
            this.txtLastModified.TabIndex = 45;
            this.txtLastModified.TabStop = false;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(91, 444);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(154, 20);
            this.txtDateCreated.TabIndex = 44;
            this.txtDateCreated.TabStop = false;
            // 
            // txtTicketNum
            // 
            this.txtTicketNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNum.Location = new System.Drawing.Point(365, 42);
            this.txtTicketNum.Name = "txtTicketNum";
            this.txtTicketNum.ReadOnly = true;
            this.txtTicketNum.Size = new System.Drawing.Size(226, 31);
            this.txtTicketNum.TabIndex = 38;
            this.txtTicketNum.TabStop = false;
            this.txtTicketNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AllowUserToOrderColumns = true;
            this.dgvNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateAdded,
            this.AddedBy,
            this.Note});
            this.dgvNotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotes.Location = new System.Drawing.Point(597, 42);
            this.dgvNotes.MultiSelect = false;
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(629, 396);
            this.dgvNotes.TabIndex = 37;
            this.dgvNotes.TabStop = false;
            this.dgvNotes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellContentDoubleClick);
            // 
            // DateAdded
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DateAdded.DefaultCellStyle = dataGridViewCellStyle2;
            this.DateAdded.HeaderText = "Date Added";
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            this.DateAdded.Width = 115;
            // 
            // AddedBy
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddedBy.DefaultCellStyle = dataGridViewCellStyle3;
            this.AddedBy.HeaderText = "Added By";
            this.AddedBy.Name = "AddedBy";
            this.AddedBy.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Note.DefaultCellStyle = dataGridViewCellStyle4;
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 200;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 200;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Notes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Last Updated:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date Created:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ticket ID:";
            // 
            // btnInProgress
            // 
            this.btnInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInProgress.Location = new System.Drawing.Point(88, 503);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(201, 37);
            this.btnInProgress.TabIndex = 2;
            this.btnInProgress.Text = "ReSubmit";
            this.btnInProgress.UseVisualStyleBackColor = true;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Noto Sans SC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(347, 70);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ticket Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtRequestorID);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtRequestorName);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 105);
            this.panel1.TabIndex = 54;
            // 
            // txtRequestorID
            // 
            this.txtRequestorID.Location = new System.Drawing.Point(108, 6);
            this.txtRequestorID.Name = "txtRequestorID";
            this.txtRequestorID.ReadOnly = true;
            this.txtRequestorID.Size = new System.Drawing.Size(463, 20);
            this.txtRequestorID.TabIndex = 11;
            this.txtRequestorID.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Requestor\'s ID:";
            // 
            // txtRequestorName
            // 
            this.txtRequestorName.Location = new System.Drawing.Point(107, 32);
            this.txtRequestorName.Name = "txtRequestorName";
            this.txtRequestorName.ReadOnly = true;
            this.txtRequestorName.Size = new System.Drawing.Size(463, 20);
            this.txtRequestorName.TabIndex = 13;
            this.txtRequestorName.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Requestor\'s Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Email Address:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Contact Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TabStop = false;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(413, 61);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(157, 20);
            this.txtContact.TabIndex = 17;
            this.txtContact.TabStop = false;
            // 
            // txtTicketStatus
            // 
            this.txtTicketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketStatus.Location = new System.Drawing.Point(91, 198);
            this.txtTicketStatus.Name = "txtTicketStatus";
            this.txtTicketStatus.ReadOnly = true;
            this.txtTicketStatus.Size = new System.Drawing.Size(198, 20);
            this.txtTicketStatus.TabIndex = 81;
            this.txtTicketStatus.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(91, 291);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(500, 147);
            this.txtDescription.TabIndex = 79;
            this.txtDescription.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(91, 265);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(500, 20);
            this.txtTitle.TabIndex = 77;
            this.txtTitle.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 80;
            this.label18.Text = "Status:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 227);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Category:*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 78;
            this.label20.Text = "Description:*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(51, 272);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 76;
            this.label21.Text = "Title:*";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblAddNoteSuccess);
            this.groupBox1.Controls.Add(this.txtAddNote);
            this.groupBox1.Controls.Add(this.btnAddNote);
            this.groupBox1.Location = new System.Drawing.Point(598, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 137);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Note";
            // 
            // lblAddNoteSuccess
            // 
            this.lblAddNoteSuccess.BackColor = System.Drawing.Color.Lime;
            this.lblAddNoteSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNoteSuccess.Location = new System.Drawing.Point(20, 16);
            this.lblAddNoteSuccess.Name = "lblAddNoteSuccess";
            this.lblAddNoteSuccess.Size = new System.Drawing.Size(516, 20);
            this.lblAddNoteSuccess.TabIndex = 2;
            this.lblAddNoteSuccess.Text = "Note added successfully!";
            this.lblAddNoteSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddNoteSuccess.Visible = false;
            // 
            // btnPending
            // 
            this.btnPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.Location = new System.Drawing.Point(88, 546);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(201, 37);
            this.btnPending.TabIndex = 5;
            this.btnPending.Text = "Return to Requestor";
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(295, 546);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Mark as Closed/Resolved";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPriority
            // 
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriority.Location = new System.Drawing.Point(438, 198);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.ReadOnly = true;
            this.txtPriority.Size = new System.Drawing.Size(153, 20);
            this.txtPriority.TabIndex = 86;
            this.txtPriority.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Priority Level";
            // 
            // txtTicketCategory
            // 
            this.txtTicketCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketCategory.Location = new System.Drawing.Point(95, 227);
            this.txtTicketCategory.Name = "txtTicketCategory";
            this.txtTicketCategory.ReadOnly = true;
            this.txtTicketCategory.Size = new System.Drawing.Size(496, 20);
            this.txtTicketCategory.TabIndex = 87;
            this.txtTicketCategory.TabStop = false;
            // 
            // tmrNoteSuccess
            // 
            this.tmrNoteSuccess.Interval = 1000;
            this.tmrNoteSuccess.Tick += new System.EventHandler(this.tmrNoteSuccess_Tick);
            // 
            // frmTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 602);
            this.Controls.Add(this.txtTicketCategory);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTicketStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLastModified);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtTicketNum);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmTicketView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTicketView_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTicketView_FormClosed);
            this.Load += new System.EventHandler(this.frmTicketView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;


        internal System.Windows.Forms.Button btnPending;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAddNote;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.TextBox txtTicketStatus;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.TextBox txtRequestorName;
        internal System.Windows.Forms.TextBox txtRequestorID;
        internal System.Windows.Forms.RichTextBox txtAddNote;
        internal System.Windows.Forms.TextBox txtLastModified;
        internal System.Windows.Forms.TextBox txtDateCreated;
        internal System.Windows.Forms.TextBox txtTicketNum;
        internal System.Windows.Forms.DataGridView dgvNotes;
        internal System.Windows.Forms.Button btnInProgress;
        internal System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTicketCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        internal System.Windows.Forms.Label lblAddNoteSuccess;
        internal System.Windows.Forms.Timer tmrNoteSuccess;
    }
}