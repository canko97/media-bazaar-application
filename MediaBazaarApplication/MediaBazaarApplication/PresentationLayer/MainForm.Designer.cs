namespace MediaBazaarApplication
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHomeMenu = new System.Windows.Forms.Button();
            this.btnEmpMenu = new System.Windows.Forms.Button();
            this.btnStckMenu = new System.Windows.Forms.Button();
            this.btnDepMenu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmpOverview = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAutoFillDaysAhead = new System.Windows.Forms.TextBox();
            this.tbEmployeePerShift = new System.Windows.Forms.TextBox();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectDepartment = new System.Windows.Forms.Button();
            this.dataGridEmpOverview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.tabStockOverview = new System.Windows.Forms.TabPage();
            this.btn_RestockToMax = new System.Windows.Forms.Button();
            this.btnRestockToMin = new System.Windows.Forms.Button();
            this.RestockGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximum_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInUserRole = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabEmpOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpOverview)).BeginInit();
            this.tabStockOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHomeMenu
            // 
            this.btnHomeMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHomeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMenu.Location = new System.Drawing.Point(9, 11);
            this.btnHomeMenu.Name = "btnHomeMenu";
            this.btnHomeMenu.Size = new System.Drawing.Size(116, 57);
            this.btnHomeMenu.TabIndex = 0;
            this.btnHomeMenu.Text = "Home";
            this.btnHomeMenu.UseVisualStyleBackColor = false;
            // 
            // btnEmpMenu
            // 
            this.btnEmpMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnEmpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpMenu.Location = new System.Drawing.Point(41, 67);
            this.btnEmpMenu.Name = "btnEmpMenu";
            this.btnEmpMenu.Size = new System.Drawing.Size(84, 57);
            this.btnEmpMenu.TabIndex = 1;
            this.btnEmpMenu.Text = "Employees";
            this.btnEmpMenu.UseVisualStyleBackColor = false;
            this.btnEmpMenu.Click += new System.EventHandler(this.btnEmpMenu_Click);
            // 
            // btnStckMenu
            // 
            this.btnStckMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnStckMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStckMenu.Location = new System.Drawing.Point(41, 122);
            this.btnStckMenu.Name = "btnStckMenu";
            this.btnStckMenu.Size = new System.Drawing.Size(84, 57);
            this.btnStckMenu.TabIndex = 2;
            this.btnStckMenu.Text = "Stock ";
            this.btnStckMenu.UseVisualStyleBackColor = false;
            this.btnStckMenu.Click += new System.EventHandler(this.btnStckMenu_Click);
            // 
            // btnDepMenu
            // 
            this.btnDepMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnDepMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepMenu.Location = new System.Drawing.Point(41, 176);
            this.btnDepMenu.Name = "btnDepMenu";
            this.btnDepMenu.Size = new System.Drawing.Size(84, 57);
            this.btnDepMenu.TabIndex = 3;
            this.btnDepMenu.Text = "Departments";
            this.btnDepMenu.UseVisualStyleBackColor = false;
            this.btnDepMenu.Click += new System.EventHandler(this.btnDepMenu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabEmpOverview);
            this.tabControl1.Controls.Add(this.tabStockOverview);
            this.tabControl1.Location = new System.Drawing.Point(124, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmpOverview
            // 
            this.tabEmpOverview.Controls.Add(this.label3);
            this.tabEmpOverview.Controls.Add(this.label2);
            this.tabEmpOverview.Controls.Add(this.tbAutoFillDaysAhead);
            this.tabEmpOverview.Controls.Add(this.tbEmployeePerShift);
            this.tabEmpOverview.Controls.Add(this.btnAutoFill);
            this.tabEmpOverview.Controls.Add(this.label1);
            this.tabEmpOverview.Controls.Add(this.btnSelectDepartment);
            this.tabEmpOverview.Controls.Add(this.dataGridEmpOverview);
            this.tabEmpOverview.Controls.Add(this.cbDepartment);
            this.tabEmpOverview.Location = new System.Drawing.Point(4, 22);
            this.tabEmpOverview.Name = "tabEmpOverview";
            this.tabEmpOverview.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabEmpOverview.Size = new System.Drawing.Size(896, 417);
            this.tabEmpOverview.TabIndex = 0;
            this.tabEmpOverview.Text = "Employee Overview";
            this.tabEmpOverview.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Days Ahead";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Employee Count\r\n      Per Shift";
            // 
            // tbAutoFillDaysAhead
            // 
            this.tbAutoFillDaysAhead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAutoFillDaysAhead.Location = new System.Drawing.Point(412, 394);
            this.tbAutoFillDaysAhead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAutoFillDaysAhead.Name = "tbAutoFillDaysAhead";
            this.tbAutoFillDaysAhead.Size = new System.Drawing.Size(61, 20);
            this.tbAutoFillDaysAhead.TabIndex = 40;
            // 
            // tbEmployeePerShift
            // 
            this.tbEmployeePerShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbEmployeePerShift.Location = new System.Drawing.Point(326, 394);
            this.tbEmployeePerShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmployeePerShift.Name = "tbEmployeePerShift";
            this.tbEmployeePerShift.Size = new System.Drawing.Size(61, 20);
            this.tbEmployeePerShift.TabIndex = 39;
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoFill.Location = new System.Drawing.Point(490, 364);
            this.btnAutoFill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(94, 50);
            this.btnAutoFill.TabIndex = 38;
            this.btnAutoFill.Text = "Fill Shifts";
            this.btnAutoFill.UseVisualStyleBackColor = true;
            this.btnAutoFill.Click += new System.EventHandler(this.btnAutoFill_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Current Day:";
            // 
            // btnSelectDepartment
            // 
            this.btnSelectDepartment.Location = new System.Drawing.Point(203, 10);
            this.btnSelectDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectDepartment.Name = "btnSelectDepartment";
            this.btnSelectDepartment.Size = new System.Drawing.Size(109, 24);
            this.btnSelectDepartment.TabIndex = 36;
            this.btnSelectDepartment.Text = "Select Department";
            this.btnSelectDepartment.UseVisualStyleBackColor = true;
            this.btnSelectDepartment.Click += new System.EventHandler(this.btnSelectDepartment_Click);
            // 
            // dataGridEmpOverview
            // 
            this.dataGridEmpOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmpOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmpOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEmpOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEmpOverview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEmpOverview.Location = new System.Drawing.Point(75, 38);
            this.dataGridEmpOverview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridEmpOverview.Name = "dataGridEmpOverview";
            this.dataGridEmpOverview.ReadOnly = true;
            this.dataGridEmpOverview.RowHeadersWidth = 100;
            this.dataGridEmpOverview.RowTemplate.Height = 24;
            this.dataGridEmpOverview.Size = new System.Drawing.Size(805, 314);
            this.dataGridEmpOverview.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Assigned Employees / Expected Employees";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(76, 12);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(123, 21);
            this.cbDepartment.TabIndex = 33;
            // 
            // tabStockOverview
            // 
            this.tabStockOverview.Controls.Add(this.btn_RestockToMax);
            this.tabStockOverview.Controls.Add(this.btnRestockToMin);
            this.tabStockOverview.Controls.Add(this.RestockGridView);
            this.tabStockOverview.Location = new System.Drawing.Point(4, 22);
            this.tabStockOverview.Name = "tabStockOverview";
            this.tabStockOverview.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabStockOverview.Size = new System.Drawing.Size(896, 417);
            this.tabStockOverview.TabIndex = 1;
            this.tabStockOverview.Text = "Stock Overview";
            this.tabStockOverview.UseVisualStyleBackColor = true;
            // 
            // btn_RestockToMax
            // 
            this.btn_RestockToMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_RestockToMax.Location = new System.Drawing.Point(472, 371);
            this.btn_RestockToMax.Name = "btn_RestockToMax";
            this.btn_RestockToMax.Size = new System.Drawing.Size(141, 45);
            this.btn_RestockToMax.TabIndex = 4;
            this.btn_RestockToMax.Text = "Restock To Maximum Quantity";
            this.btn_RestockToMax.UseVisualStyleBackColor = true;
            this.btn_RestockToMax.Click += new System.EventHandler(this.btn_RestockToMax_Click);
            // 
            // btnRestockToMin
            // 
            this.btnRestockToMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRestockToMin.Location = new System.Drawing.Point(260, 371);
            this.btnRestockToMin.Name = "btnRestockToMin";
            this.btnRestockToMin.Size = new System.Drawing.Size(141, 45);
            this.btnRestockToMin.TabIndex = 3;
            this.btnRestockToMin.Text = "Restock To Minimum Quantity";
            this.btnRestockToMin.UseVisualStyleBackColor = true;
            this.btnRestockToMin.Click += new System.EventHandler(this.btnRestockToMin_Click);
            // 
            // RestockGridView
            // 
            this.RestockGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestockGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RestockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestockGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.MinimumQuantity,
            this.Maximum_Quantity,
            this.WarehouseAmount,
            this.MinimumDifference,
            this.MaximumDifference});
            this.RestockGridView.Location = new System.Drawing.Point(3, 3);
            this.RestockGridView.Name = "RestockGridView";
            this.RestockGridView.RowHeadersWidth = 51;
            this.RestockGridView.RowTemplate.Height = 24;
            this.RestockGridView.Size = new System.Drawing.Size(827, 363);
            this.RestockGridView.TabIndex = 2;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // MinimumQuantity
            // 
            this.MinimumQuantity.HeaderText = "Minimum Quantity";
            this.MinimumQuantity.MinimumWidth = 6;
            this.MinimumQuantity.Name = "MinimumQuantity";
            // 
            // Maximum_Quantity
            // 
            this.Maximum_Quantity.HeaderText = "Maximum Quantity";
            this.Maximum_Quantity.MinimumWidth = 6;
            this.Maximum_Quantity.Name = "Maximum_Quantity";
            // 
            // WarehouseAmount
            // 
            this.WarehouseAmount.HeaderText = "Warehouse Amount";
            this.WarehouseAmount.MinimumWidth = 6;
            this.WarehouseAmount.Name = "WarehouseAmount";
            // 
            // MinimumDifference
            // 
            this.MinimumDifference.HeaderText = "Minimum Difference";
            this.MinimumDifference.MinimumWidth = 6;
            this.MinimumDifference.Name = "MinimumDifference";
            // 
            // MaximumDifference
            // 
            this.MaximumDifference.HeaderText = "Maximum Difference";
            this.MaximumDifference.MinimumWidth = 6;
            this.MaximumDifference.Name = "MaximumDifference";
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLastName.ForeColor = System.Drawing.Color.White;
            this.lblUserLastName.Location = new System.Drawing.Point(1, 394);
            this.lblUserLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(46, 17);
            this.lblUserLastName.TabIndex = 4;
            this.lblUserLastName.Text = "label1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(41, 232);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 61);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblLoggedInUserRole
            // 
            this.lblLoggedInUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoggedInUserRole.AutoSize = true;
            this.lblLoggedInUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUserRole.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInUserRole.Location = new System.Drawing.Point(1, 433);
            this.lblLoggedInUserRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedInUserRole.Name = "lblLoggedInUserRole";
            this.lblLoggedInUserRole.Size = new System.Drawing.Size(46, 17);
            this.lblLoggedInUserRole.TabIndex = 14;
            this.lblLoggedInUserRole.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1047, 474);
            this.Controls.Add(this.lblLoggedInUserRole);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDepMenu);
            this.Controls.Add(this.btnStckMenu);
            this.Controls.Add(this.btnEmpMenu);
            this.Controls.Add(this.btnHomeMenu);
            this.Controls.Add(this.btnLogOut);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabEmpOverview.ResumeLayout(false);
            this.tabEmpOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpOverview)).EndInit();
            this.tabStockOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomeMenu;
        private System.Windows.Forms.Button btnEmpMenu;
        private System.Windows.Forms.Button btnStckMenu;
        private System.Windows.Forms.Button btnDepMenu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmpOverview;
        private System.Windows.Forms.TabPage tabStockOverview;
        private System.Windows.Forms.Button btnRestockToMin;
        private System.Windows.Forms.DataGridView RestockGridView;

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.DataGridView dataGridEmpOverview;
        private System.Windows.Forms.Button btnSelectDepartment;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAutoFill;
        private System.Windows.Forms.TextBox tbEmployeePerShift;
        private System.Windows.Forms.TextBox tbAutoFillDaysAhead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_RestockToMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximum_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumDifference;
        private System.Windows.Forms.Label lblLoggedInUserRole;
    }
}

