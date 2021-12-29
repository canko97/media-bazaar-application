namespace MediaBazaarApplication
{
    partial class EmployeeView
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonalDetails = new System.Windows.Forms.TabPage();
            this.pnlPersonalInfo = new System.Windows.Forms.Panel();
            this.gbHoliday = new System.Windows.Forms.GroupBox();
            this.lblHolidayApproval = new System.Windows.Forms.Label();
            this.btnRequestHoliday = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpHolidayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpHolidayStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbSunday = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSaturday = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbFriday = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbThursday = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbWednesday = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTuesday = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMonday = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRefreshSchedule = new System.Windows.Forms.Button();
            this.btnViewPersonalSchedule = new System.Windows.Forms.Button();
            this.gridEmpPersonalSchedule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHouseNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpRestock = new System.Windows.Forms.TabPage();
            this.pnlRestock = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_StockToStore = new System.Windows.Forms.TextBox();
            this.btn_AddStockToStore = new System.Windows.Forms.Button();
            this.tb_AmountRestocked = new System.Windows.Forms.TextBox();
            this.btnRestock = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpPersonalDetails.SuspendLayout();
            this.pnlPersonalInfo.SuspendLayout();
            this.gbHoliday.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpPersonalSchedule)).BeginInit();
            this.tpRestock.SuspendLayout();
            this.pnlRestock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.tabControl1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1396, 618);
            this.panelMain.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpPersonalDetails);
            this.tabControl1.Controls.Add(this.tpRestock);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1365, 587);
            this.tabControl1.TabIndex = 4;
            // 
            // tpPersonalDetails
            // 
            this.tpPersonalDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpPersonalDetails.Controls.Add(this.pnlPersonalInfo);
            this.tpPersonalDetails.Location = new System.Drawing.Point(4, 25);
            this.tpPersonalDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPersonalDetails.Name = "tpPersonalDetails";
            this.tpPersonalDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPersonalDetails.Size = new System.Drawing.Size(1357, 558);
            this.tpPersonalDetails.TabIndex = 0;
            this.tpPersonalDetails.Text = "Personal Details";
            // 
            // pnlPersonalInfo
            // 
            this.pnlPersonalInfo.Controls.Add(this.gbHoliday);
            this.pnlPersonalInfo.Controls.Add(this.groupBox2);
            this.pnlPersonalInfo.Controls.Add(this.btnLogOut);
            this.pnlPersonalInfo.Controls.Add(this.btnRefreshSchedule);
            this.pnlPersonalInfo.Controls.Add(this.btnViewPersonalSchedule);
            this.pnlPersonalInfo.Controls.Add(this.gridEmpPersonalSchedule);
            this.pnlPersonalInfo.Controls.Add(this.btnSave);
            this.pnlPersonalInfo.Controls.Add(this.label9);
            this.pnlPersonalInfo.Controls.Add(this.tbCity);
            this.pnlPersonalInfo.Controls.Add(this.label8);
            this.pnlPersonalInfo.Controls.Add(this.tbHouseNr);
            this.pnlPersonalInfo.Controls.Add(this.label7);
            this.pnlPersonalInfo.Controls.Add(this.tbStreet);
            this.pnlPersonalInfo.Controls.Add(this.label5);
            this.pnlPersonalInfo.Controls.Add(this.tbPhone);
            this.pnlPersonalInfo.Controls.Add(this.lblDOB);
            this.pnlPersonalInfo.Controls.Add(this.label6);
            this.pnlPersonalInfo.Controls.Add(this.label3);
            this.pnlPersonalInfo.Controls.Add(this.tbEmail);
            this.pnlPersonalInfo.Controls.Add(this.lblLastName);
            this.pnlPersonalInfo.Controls.Add(this.label4);
            this.pnlPersonalInfo.Controls.Add(this.lblFirstName);
            this.pnlPersonalInfo.Controls.Add(this.label2);
            this.pnlPersonalInfo.Controls.Add(this.lblId);
            this.pnlPersonalInfo.Controls.Add(this.label1);
            this.pnlPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersonalInfo.ForeColor = System.Drawing.Color.White;
            this.pnlPersonalInfo.Location = new System.Drawing.Point(3, 2);
            this.pnlPersonalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPersonalInfo.Name = "pnlPersonalInfo";
            this.pnlPersonalInfo.Size = new System.Drawing.Size(1351, 554);
            this.pnlPersonalInfo.TabIndex = 3;
            // 
            // gbHoliday
            // 
            this.gbHoliday.Controls.Add(this.lblHolidayApproval);
            this.gbHoliday.Controls.Add(this.btnRequestHoliday);
            this.gbHoliday.Controls.Add(this.label18);
            this.gbHoliday.Controls.Add(this.label17);
            this.gbHoliday.Controls.Add(this.dtpHolidayEnd);
            this.gbHoliday.Controls.Add(this.dtpHolidayStart);
            this.gbHoliday.ForeColor = System.Drawing.Color.White;
            this.gbHoliday.Location = new System.Drawing.Point(14, 317);
            this.gbHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHoliday.Name = "gbHoliday";
            this.gbHoliday.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbHoliday.Size = new System.Drawing.Size(548, 110);
            this.gbHoliday.TabIndex = 33;
            this.gbHoliday.TabStop = false;
            this.gbHoliday.Text = "Leave";
            // 
            // lblHolidayApproval
            // 
            this.lblHolidayApproval.BackColor = System.Drawing.Color.Black;
            this.lblHolidayApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolidayApproval.ForeColor = System.Drawing.Color.White;
            this.lblHolidayApproval.Location = new System.Drawing.Point(421, 30);
            this.lblHolidayApproval.Name = "lblHolidayApproval";
            this.lblHolidayApproval.Size = new System.Drawing.Size(112, 64);
            this.lblHolidayApproval.TabIndex = 36;
            this.lblHolidayApproval.Text = "Leave Request Status";
            // 
            // btnRequestHoliday
            // 
            this.btnRequestHoliday.ForeColor = System.Drawing.Color.Black;
            this.btnRequestHoliday.Location = new System.Drawing.Point(295, 30);
            this.btnRequestHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestHoliday.Name = "btnRequestHoliday";
            this.btnRequestHoliday.Size = new System.Drawing.Size(100, 64);
            this.btnRequestHoliday.TabIndex = 34;
            this.btnRequestHoliday.Text = "Request Leave";
            this.btnRequestHoliday.UseVisualStyleBackColor = true;
            this.btnRequestHoliday.Click += new System.EventHandler(this.btnRequestHoliday_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "End:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Start:";
            // 
            // dtpHolidayEnd
            // 
            this.dtpHolidayEnd.Location = new System.Drawing.Point(53, 72);
            this.dtpHolidayEnd.Name = "dtpHolidayEnd";
            this.dtpHolidayEnd.Size = new System.Drawing.Size(220, 22);
            this.dtpHolidayEnd.TabIndex = 1;
            // 
            // dtpHolidayStart
            // 
            this.dtpHolidayStart.Location = new System.Drawing.Point(54, 30);
            this.dtpHolidayStart.Name = "dtpHolidayStart";
            this.dtpHolidayStart.Size = new System.Drawing.Size(219, 22);
            this.dtpHolidayStart.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbSunday);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbSaturday);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbFriday);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbThursday);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbWednesday);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbTuesday);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbMonday);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(269, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(293, 254);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unavailability";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Sunday";
            // 
            // cbSunday
            // 
            this.cbSunday.FormattingEnabled = true;
            this.cbSunday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbSunday.Location = new System.Drawing.Point(125, 210);
            this.cbSunday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(153, 24);
            this.cbSunday.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Saturday";
            // 
            // cbSaturday
            // 
            this.cbSaturday.FormattingEnabled = true;
            this.cbSaturday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbSaturday.Location = new System.Drawing.Point(125, 181);
            this.cbSaturday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(153, 24);
            this.cbSaturday.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Friday";
            // 
            // cbFriday
            // 
            this.cbFriday.FormattingEnabled = true;
            this.cbFriday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbFriday.Location = new System.Drawing.Point(125, 151);
            this.cbFriday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(153, 24);
            this.cbFriday.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Thursday";
            // 
            // cbThursday
            // 
            this.cbThursday.FormattingEnabled = true;
            this.cbThursday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbThursday.Location = new System.Drawing.Point(125, 121);
            this.cbThursday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(153, 24);
            this.cbThursday.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Wednesday";
            // 
            // cbWednesday
            // 
            this.cbWednesday.FormattingEnabled = true;
            this.cbWednesday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbWednesday.Location = new System.Drawing.Point(125, 91);
            this.cbWednesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(153, 24);
            this.cbWednesday.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tuesday";
            // 
            // cbTuesday
            // 
            this.cbTuesday.FormattingEnabled = true;
            this.cbTuesday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbTuesday.Location = new System.Drawing.Point(125, 62);
            this.cbTuesday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(153, 24);
            this.cbTuesday.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Monday";
            // 
            // cbMonday
            // 
            this.cbMonday.FormattingEnabled = true;
            this.cbMonday.Items.AddRange(new object[] {
            "NONE",
            "MORNING",
            "AFTERNOON",
            "EVENING",
            "ALL"});
            this.cbMonday.Location = new System.Drawing.Point(125, 31);
            this.cbMonday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(153, 24);
            this.cbMonday.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(27, 460);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 75);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRefreshSchedule
            // 
            this.btnRefreshSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshSchedule.Location = new System.Drawing.Point(197, 508);
            this.btnRefreshSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshSchedule.Name = "btnRefreshSchedule";
            this.btnRefreshSchedule.Size = new System.Drawing.Size(235, 34);
            this.btnRefreshSchedule.TabIndex = 31;
            this.btnRefreshSchedule.Text = "Refresh Schedule";
            this.btnRefreshSchedule.UseVisualStyleBackColor = true;
            this.btnRefreshSchedule.Click += new System.EventHandler(this.btnRefreshSchedule_Click);
            // 
            // btnViewPersonalSchedule
            // 
            this.btnViewPersonalSchedule.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewPersonalSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewPersonalSchedule.Location = new System.Drawing.Point(197, 508);
            this.btnViewPersonalSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPersonalSchedule.Name = "btnViewPersonalSchedule";
            this.btnViewPersonalSchedule.Size = new System.Drawing.Size(235, 34);
            this.btnViewPersonalSchedule.TabIndex = 30;
            this.btnViewPersonalSchedule.Text = "View Your Schedule";
            this.btnViewPersonalSchedule.UseVisualStyleBackColor = false;
            this.btnViewPersonalSchedule.Click += new System.EventHandler(this.btnViewPersonalSchedule_Click);
            // 
            // gridEmpPersonalSchedule
            // 
            this.gridEmpPersonalSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEmpPersonalSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmpPersonalSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpPersonalSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridEmpPersonalSchedule.Location = new System.Drawing.Point(568, 2);
            this.gridEmpPersonalSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridEmpPersonalSchedule.Name = "gridEmpPersonalSchedule";
            this.gridEmpPersonalSchedule.RowHeadersWidth = 100;
            this.gridEmpPersonalSchedule.RowTemplate.Height = 24;
            this.gridEmpPersonalSchedule.Size = new System.Drawing.Size(780, 549);
            this.gridEmpPersonalSchedule.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Morning Shift";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Afternoon Shift";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Evening Shift";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(197, 444);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 58);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save Details and Unavailability";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "City:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(100, 261);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(149, 22);
            this.tbCity.TabIndex = 26;
            this.tbCity.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "House NR:";
            // 
            // tbHouseNr
            // 
            this.tbHouseNr.Location = new System.Drawing.Point(100, 233);
            this.tbHouseNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHouseNr.Name = "tbHouseNr";
            this.tbHouseNr.Size = new System.Drawing.Size(149, 22);
            this.tbHouseNr.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Street:";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(100, 206);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(149, 22);
            this.tbStreet.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(100, 177);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(149, 22);
            this.tbPhone.TabIndex = 20;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(97, 126);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(32, 17);
            this.lblDOB.TabIndex = 19;
            this.lblDOB.Text = "dob";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "DoB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(100, 149);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(149, 22);
            this.tbEmail.TabIndex = 16;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(97, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 17);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "lastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(97, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 17);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "firstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(43, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // tpRestock
            // 
            this.tpRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tpRestock.Controls.Add(this.pnlRestock);
            this.tpRestock.Location = new System.Drawing.Point(4, 25);
            this.tpRestock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRestock.Name = "tpRestock";
            this.tpRestock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRestock.Size = new System.Drawing.Size(1357, 565);
            this.tpRestock.TabIndex = 1;
            this.tpRestock.Text = "Restock";
            // 
            // pnlRestock
            // 
            this.pnlRestock.Controls.Add(this.groupBox1);
            this.pnlRestock.Controls.Add(this.dgvItems);
            this.pnlRestock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRestock.Location = new System.Drawing.Point(3, 2);
            this.pnlRestock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRestock.Name = "pnlRestock";
            this.pnlRestock.Size = new System.Drawing.Size(1351, 561);
            this.pnlRestock.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_StockToStore);
            this.groupBox1.Controls.Add(this.btn_AddStockToStore);
            this.groupBox1.Controls.Add(this.tb_AmountRestocked);
            this.groupBox1.Controls.Add(this.btnRestock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(189, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock";
            // 
            // tb_StockToStore
            // 
            this.tb_StockToStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_StockToStore.Location = new System.Drawing.Point(5, 143);
            this.tb_StockToStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_StockToStore.Name = "tb_StockToStore";
            this.tb_StockToStore.Size = new System.Drawing.Size(174, 22);
            this.tb_StockToStore.TabIndex = 37;
            // 
            // btn_AddStockToStore
            // 
            this.btn_AddStockToStore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddStockToStore.Location = new System.Drawing.Point(5, 113);
            this.btn_AddStockToStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddStockToStore.Name = "btn_AddStockToStore";
            this.btn_AddStockToStore.Size = new System.Drawing.Size(173, 32);
            this.btn_AddStockToStore.TabIndex = 36;
            this.btn_AddStockToStore.Text = "Transfer Stock To Store";
            this.btn_AddStockToStore.UseVisualStyleBackColor = true;
            this.btn_AddStockToStore.Click += new System.EventHandler(this.btn_Destock_Click_1);
            // 
            // tb_AmountRestocked
            // 
            this.tb_AmountRestocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AmountRestocked.Location = new System.Drawing.Point(5, 69);
            this.tb_AmountRestocked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_AmountRestocked.Name = "tb_AmountRestocked";
            this.tb_AmountRestocked.Size = new System.Drawing.Size(174, 22);
            this.tb_AmountRestocked.TabIndex = 35;
            // 
            // btnRestock
            // 
            this.btnRestock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestock.Location = new System.Drawing.Point(5, 39);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(173, 34);
            this.btnRestock.TabIndex = 34;
            this.btnRestock.Text = "Restock Item";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click_1);
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItems.Location = new System.Drawing.Point(193, 0);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(1158, 561);
            this.dgvItems.TabIndex = 1;
            this.dgvItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvItems_DataBindingComplete_1);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ProductID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Description";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Category";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Store Amount";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Quantity";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Minimum Quantity";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1396, 618);
            this.Controls.Add(this.panelMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1414, 665);
            this.Name = "EmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Bazaar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeView_FormClosed);
            this.panelMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonalDetails.ResumeLayout(false);
            this.pnlPersonalInfo.ResumeLayout(false);
            this.pnlPersonalInfo.PerformLayout();
            this.gbHoliday.ResumeLayout(false);
            this.gbHoliday.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpPersonalSchedule)).EndInit();
            this.tpRestock.ResumeLayout(false);
            this.pnlRestock.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_StockToStore;
        private System.Windows.Forms.Button btn_AddStockToStore;
        private System.Windows.Forms.TextBox tb_AmountRestocked;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.Panel pnlRestock;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonalDetails;
        private System.Windows.Forms.Panel pnlPersonalInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHouseNr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpRestock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gridEmpPersonalSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnViewPersonalSchedule;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRefreshSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbSunday;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbSaturday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbFriday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbThursday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbWednesday;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTuesday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMonday;
        private System.Windows.Forms.GroupBox gbHoliday;
        private System.Windows.Forms.Label lblHolidayApproval;
        private System.Windows.Forms.Button btnRequestHoliday;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpHolidayEnd;
        private System.Windows.Forms.DateTimePicker dtpHolidayStart;
    }
}