namespace MediaBazaarApplication
{
    partial class DepartmentsForm
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
            this.btnAssignManager = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnDepMenu = new System.Windows.Forms.Button();
            this.btnStckMenu = new System.Windows.Forms.Button();
            this.btnEmpMenu = new System.Windows.Forms.Button();
            this.btnHomeMenu = new System.Windows.Forms.Button();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInUserRole = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.btnAssignManager);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.tbDepartmentName);
            this.panelMain.Controls.Add(this.btnEdit);
            this.panelMain.Controls.Add(this.btnRemove);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.dgvDepartments);
            this.panelMain.Location = new System.Drawing.Point(127, 19);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(910, 446);
            this.panelMain.TabIndex = 19;
            // 
            // btnAssignManager
            // 
            this.btnAssignManager.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAssignManager.FlatAppearance.BorderSize = 0;
            this.btnAssignManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignManager.ForeColor = System.Drawing.Color.White;
            this.btnAssignManager.Location = new System.Drawing.Point(7, 202);
            this.btnAssignManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignManager.Name = "btnAssignManager";
            this.btnAssignManager.Size = new System.Drawing.Size(206, 54);
            this.btnAssignManager.TabIndex = 6;
            this.btnAssignManager.Text = "EDIT MANAGERS";
            this.btnAssignManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignManager.UseVisualStyleBackColor = false;
            this.btnAssignManager.Click += new System.EventHandler(this.btnAssignManager_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department Name:";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Location = new System.Drawing.Point(121, 19);
            this.tbDepartmentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(84, 20);
            this.tbDepartmentName.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(7, 144);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(206, 54);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT DEPARTMENT";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(7, 261);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(206, 55);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "REMOVE DEPARTMENT";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(7, 83);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 56);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD DEPARTMENT";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(217, 2);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.Size = new System.Drawing.Size(686, 432);
            this.dgvDepartments.TabIndex = 0;
            this.dgvDepartments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellClick);
            // 
            // btnDepMenu
            // 
            this.btnDepMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDepMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepMenu.Location = new System.Drawing.Point(10, 186);
            this.btnDepMenu.Name = "btnDepMenu";
            this.btnDepMenu.Size = new System.Drawing.Size(119, 57);
            this.btnDepMenu.TabIndex = 18;
            this.btnDepMenu.Text = "Departments";
            this.btnDepMenu.UseVisualStyleBackColor = false;
            // 
            // btnStckMenu
            // 
            this.btnStckMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnStckMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStckMenu.Location = new System.Drawing.Point(45, 131);
            this.btnStckMenu.Name = "btnStckMenu";
            this.btnStckMenu.Size = new System.Drawing.Size(84, 56);
            this.btnStckMenu.TabIndex = 17;
            this.btnStckMenu.Text = "Stock";
            this.btnStckMenu.UseVisualStyleBackColor = false;
            this.btnStckMenu.Click += new System.EventHandler(this.btnStckMenu_Click);
            // 
            // btnEmpMenu
            // 
            this.btnEmpMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnEmpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpMenu.Location = new System.Drawing.Point(45, 75);
            this.btnEmpMenu.Name = "btnEmpMenu";
            this.btnEmpMenu.Size = new System.Drawing.Size(84, 57);
            this.btnEmpMenu.TabIndex = 16;
            this.btnEmpMenu.Text = "Employees";
            this.btnEmpMenu.UseVisualStyleBackColor = false;
            this.btnEmpMenu.Click += new System.EventHandler(this.btnEmpMenu_Click);
            // 
            // btnHomeMenu
            // 
            this.btnHomeMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnHomeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMenu.Location = new System.Drawing.Point(45, 19);
            this.btnHomeMenu.Name = "btnHomeMenu";
            this.btnHomeMenu.Size = new System.Drawing.Size(84, 57);
            this.btnHomeMenu.TabIndex = 15;
            this.btnHomeMenu.Text = "Home";
            this.btnHomeMenu.UseVisualStyleBackColor = false;
            this.btnHomeMenu.Click += new System.EventHandler(this.btnHomeMenu_Click);
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLastName.ForeColor = System.Drawing.Color.White;
            this.lblUserLastName.Location = new System.Drawing.Point(7, 384);
            this.lblUserLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(46, 17);
            this.lblUserLastName.TabIndex = 20;
            this.lblUserLastName.Text = "label1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(45, 242);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 56);
            this.btnLogOut.TabIndex = 21;
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
            this.lblLoggedInUserRole.Location = new System.Drawing.Point(7, 437);
            this.lblLoggedInUserRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedInUserRole.Name = "lblLoggedInUserRole";
            this.lblLoggedInUserRole.Size = new System.Drawing.Size(46, 17);
            this.lblLoggedInUserRole.TabIndex = 22;
            this.lblLoggedInUserRole.Text = "label2";
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1048, 480);
            this.Controls.Add(this.lblLoggedInUserRole);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnDepMenu);
            this.Controls.Add(this.btnStckMenu);
            this.Controls.Add(this.btnEmpMenu);
            this.Controls.Add(this.btnHomeMenu);
            this.Controls.Add(this.btnLogOut);
            this.MinimumSize = new System.Drawing.Size(1064, 519);
            this.Name = "DepartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DepartmentsForm_FormClosed);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnDepMenu;
        private System.Windows.Forms.Button btnStckMenu;
        private System.Windows.Forms.Button btnEmpMenu;
        private System.Windows.Forms.Button btnHomeMenu;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAssignManager;
        private System.Windows.Forms.Label lblLoggedInUserRole;
    }
}