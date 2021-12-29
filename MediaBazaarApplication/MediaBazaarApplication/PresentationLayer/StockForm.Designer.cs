namespace MediaBazaarApplication
{
    partial class StockForm
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
            this.btnDepMenu = new System.Windows.Forms.Button();
            this.btnStckMenu = new System.Windows.Forms.Button();
            this.btnEmpMenu = new System.Windows.Forms.Button();
            this.btnHomeMenu = new System.Windows.Forms.Button();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInUserRole = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_AddAndEdit = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_AddToStore = new System.Windows.Forms.Button();
            this.tb_AmountToStore = new System.Windows.Forms.TextBox();
            this.btnRestock = new System.Windows.Forms.Button();
            this.tb_AmountRestocked = new System.Windows.Forms.TextBox();
            this.tbMaxQuantity = new System.Windows.Forms.TextBox();
            this.lbl_MaxQuantity = new System.Windows.Forms.Label();
            this.btn_EditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMinQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInStoreAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btn_return = new System.Windows.Forms.Button();
            this.lbl_Item_Id = new System.Windows.Forms.Label();
            this.btn_EditStockBtn = new System.Windows.Forms.Button();
            this.tb_editItemName = new System.Windows.Forms.TextBox();
            this.tb_editInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_editPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_editCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tc_AddAndEdit.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepMenu
            // 
            this.btnDepMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnDepMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepMenu.Location = new System.Drawing.Point(44, 186);
            this.btnDepMenu.Name = "btnDepMenu";
            this.btnDepMenu.Size = new System.Drawing.Size(84, 57);
            this.btnDepMenu.TabIndex = 13;
            this.btnDepMenu.Text = "Departments";
            this.btnDepMenu.UseVisualStyleBackColor = false;
            this.btnDepMenu.Click += new System.EventHandler(this.btnDepMenu_Click);
            // 
            // btnStckMenu
            // 
            this.btnStckMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnStckMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStckMenu.Location = new System.Drawing.Point(10, 131);
            this.btnStckMenu.Name = "btnStckMenu";
            this.btnStckMenu.Size = new System.Drawing.Size(118, 56);
            this.btnStckMenu.TabIndex = 12;
            this.btnStckMenu.Text = "Stock";
            this.btnStckMenu.UseVisualStyleBackColor = false;
            // 
            // btnEmpMenu
            // 
            this.btnEmpMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnEmpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpMenu.Location = new System.Drawing.Point(44, 75);
            this.btnEmpMenu.Name = "btnEmpMenu";
            this.btnEmpMenu.Size = new System.Drawing.Size(84, 57);
            this.btnEmpMenu.TabIndex = 11;
            this.btnEmpMenu.Text = "Employees";
            this.btnEmpMenu.UseVisualStyleBackColor = false;
            this.btnEmpMenu.Click += new System.EventHandler(this.btnEmpMenu_Click);
            // 
            // btnHomeMenu
            // 
            this.btnHomeMenu.BackColor = System.Drawing.Color.DimGray;
            this.btnHomeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMenu.Location = new System.Drawing.Point(44, 19);
            this.btnHomeMenu.Name = "btnHomeMenu";
            this.btnHomeMenu.Size = new System.Drawing.Size(84, 57);
            this.btnHomeMenu.TabIndex = 10;
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
            this.lblUserLastName.Location = new System.Drawing.Point(9, 388);
            this.lblUserLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(46, 17);
            this.lblUserLastName.TabIndex = 15;
            this.lblUserLastName.Text = "label1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(44, 243);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 61);
            this.btnLogOut.TabIndex = 16;
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
            this.lblLoggedInUserRole.Location = new System.Drawing.Point(9, 440);
            this.lblLoggedInUserRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoggedInUserRole.Name = "lblLoggedInUserRole";
            this.lblLoggedInUserRole.Size = new System.Drawing.Size(46, 17);
            this.lblLoggedInUserRole.TabIndex = 17;
            this.lblLoggedInUserRole.Text = "label2";
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.Description,
            this.Category,
            this.StoreAmount,
            this.Quantity,
            this.MinimumQuantity,
            this.MaximumQuantity});
            this.dgvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvItems.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvItems.Location = new System.Drawing.Point(377, 19);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(650, 438);
            this.dgvItems.TabIndex = 41;
            this.dgvItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvItems_DataBindingComplete);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // StoreAmount
            // 
            this.StoreAmount.HeaderText = "Store Amount";
            this.StoreAmount.MinimumWidth = 6;
            this.StoreAmount.Name = "StoreAmount";
            this.StoreAmount.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // MinimumQuantity
            // 
            this.MinimumQuantity.HeaderText = "Minimum Quantity";
            this.MinimumQuantity.MinimumWidth = 6;
            this.MinimumQuantity.Name = "MinimumQuantity";
            this.MinimumQuantity.ReadOnly = true;
            // 
            // MaximumQuantity
            // 
            this.MaximumQuantity.HeaderText = "Maximum Quantity";
            this.MaximumQuantity.MinimumWidth = 6;
            this.MaximumQuantity.Name = "MaximumQuantity";
            // 
            // tc_AddAndEdit
            // 
            this.tc_AddAndEdit.Controls.Add(this.tabPage1);
            this.tc_AddAndEdit.Controls.Add(this.tabEdit);
            this.tc_AddAndEdit.Location = new System.Drawing.Point(125, 19);
            this.tc_AddAndEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc_AddAndEdit.Name = "tc_AddAndEdit";
            this.tc_AddAndEdit.SelectedIndex = 0;
            this.tc_AddAndEdit.Size = new System.Drawing.Size(250, 440);
            this.tc_AddAndEdit.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btn_AddToStore);
            this.tabPage1.Controls.Add(this.tb_AmountToStore);
            this.tabPage1.Controls.Add(this.btnRestock);
            this.tabPage1.Controls.Add(this.tb_AmountRestocked);
            this.tabPage1.Controls.Add(this.tbMaxQuantity);
            this.tabPage1.Controls.Add(this.lbl_MaxQuantity);
            this.tabPage1.Controls.Add(this.btn_EditItem);
            this.tabPage1.Controls.Add(this.btnDeleteItem);
            this.tabPage1.Controls.Add(this.tbItemName);
            this.tabPage1.Controls.Add(this.tbQuantity);
            this.tabPage1.Controls.Add(this.tbPrice);
            this.tabPage1.Controls.Add(this.tbMinQuantity);
            this.tabPage1.Controls.Add(this.btnAddItem);
            this.tabPage1.Controls.Add(this.tbInfo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbInStoreAmount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbCategory);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(242, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add/Delete";
            // 
            // btn_AddToStore
            // 
            this.btn_AddToStore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddToStore.Location = new System.Drawing.Point(92, 390);
            this.btn_AddToStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddToStore.Name = "btn_AddToStore";
            this.btn_AddToStore.Size = new System.Drawing.Size(144, 19);
            this.btn_AddToStore.TabIndex = 49;
            this.btn_AddToStore.Text = "Transfer Stock To Store";
            this.btn_AddToStore.UseVisualStyleBackColor = true;
            this.btn_AddToStore.Click += new System.EventHandler(this.btn_AddToStore_Click_1);
            // 
            // tb_AmountToStore
            // 
            this.tb_AmountToStore.Location = new System.Drawing.Point(7, 390);
            this.tb_AmountToStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_AmountToStore.Name = "tb_AmountToStore";
            this.tb_AmountToStore.Size = new System.Drawing.Size(82, 20);
            this.tb_AmountToStore.TabIndex = 48;
            // 
            // btnRestock
            // 
            this.btnRestock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestock.Location = new System.Drawing.Point(92, 363);
            this.btnRestock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(143, 19);
            this.btnRestock.TabIndex = 46;
            this.btnRestock.Text = "Restock Item";
            this.btnRestock.UseVisualStyleBackColor = true;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click_1);
            // 
            // tb_AmountRestocked
            // 
            this.tb_AmountRestocked.Location = new System.Drawing.Point(7, 364);
            this.tb_AmountRestocked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_AmountRestocked.Name = "tb_AmountRestocked";
            this.tb_AmountRestocked.Size = new System.Drawing.Size(82, 20);
            this.tb_AmountRestocked.TabIndex = 47;
            // 
            // tbMaxQuantity
            // 
            this.tbMaxQuantity.Location = new System.Drawing.Point(99, 305);
            this.tbMaxQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaxQuantity.Name = "tbMaxQuantity";
            this.tbMaxQuantity.Size = new System.Drawing.Size(138, 20);
            this.tbMaxQuantity.TabIndex = 36;
            // 
            // lbl_MaxQuantity
            // 
            this.lbl_MaxQuantity.AutoSize = true;
            this.lbl_MaxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_MaxQuantity.Location = new System.Drawing.Point(4, 305);
            this.lbl_MaxQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaxQuantity.Name = "lbl_MaxQuantity";
            this.lbl_MaxQuantity.Size = new System.Drawing.Size(98, 17);
            this.lbl_MaxQuantity.TabIndex = 35;
            this.lbl_MaxQuantity.Text = "Max. Quantity:";
            // 
            // btn_EditItem
            // 
            this.btn_EditItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_EditItem.Location = new System.Drawing.Point(82, 332);
            this.btn_EditItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_EditItem.Name = "btn_EditItem";
            this.btn_EditItem.Size = new System.Drawing.Size(86, 20);
            this.btn_EditItem.TabIndex = 34;
            this.btn_EditItem.Text = "Edit Item";
            this.btn_EditItem.UseVisualStyleBackColor = true;
            this.btn_EditItem.Click += new System.EventHandler(this.btn_EditItem_Click_1);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteItem.Location = new System.Drawing.Point(167, 332);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(68, 20);
            this.btnDeleteItem.TabIndex = 33;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click_1);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(99, 2);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(138, 20);
            this.tbItemName.TabIndex = 16;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(99, 244);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(138, 20);
            this.tbQuantity.TabIndex = 17;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(99, 37);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(138, 20);
            this.tbPrice.TabIndex = 18;
            // 
            // tbMinQuantity
            // 
            this.tbMinQuantity.Location = new System.Drawing.Point(99, 276);
            this.tbMinQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMinQuantity.Name = "tbMinQuantity";
            this.tbMinQuantity.Size = new System.Drawing.Size(138, 20);
            this.tbMinQuantity.TabIndex = 21;
            // 
            // btnAddItem
            // 
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddItem.Location = new System.Drawing.Point(7, 332);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(78, 20);
            this.btnAddItem.TabIndex = 32;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(44, 80);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(194, 71);
            this.tbInfo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "In-store amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(4, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Item Name";
            // 
            // tbInStoreAmount
            // 
            this.tbInStoreAmount.Location = new System.Drawing.Point(122, 207);
            this.tbInStoreAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInStoreAmount.Name = "tbInStoreAmount";
            this.tbInStoreAmount.Size = new System.Drawing.Size(116, 20);
            this.tbInStoreAmount.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Price:";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "LAPTOPS",
            "HEADPHONES",
            "MOUSES",
            "KEYBOARDS"});
            this.cbCategory.Location = new System.Drawing.Point(99, 171);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(138, 21);
            this.cbCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(4, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Min. Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(4, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(4, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Category:";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabEdit.Controls.Add(this.btn_return);
            this.tabEdit.Controls.Add(this.lbl_Item_Id);
            this.tabEdit.Controls.Add(this.btn_EditStockBtn);
            this.tabEdit.Controls.Add(this.tb_editItemName);
            this.tabEdit.Controls.Add(this.tb_editInfo);
            this.tabEdit.Controls.Add(this.label10);
            this.tabEdit.Controls.Add(this.tb_editPrice);
            this.tabEdit.Controls.Add(this.label11);
            this.tabEdit.Controls.Add(this.label9);
            this.tabEdit.Controls.Add(this.cb_editCategory);
            this.tabEdit.Controls.Add(this.label12);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEdit.Size = new System.Drawing.Size(242, 414);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            // 
            // btn_return
            // 
            this.btn_return.ForeColor = System.Drawing.Color.Black;
            this.btn_return.Location = new System.Drawing.Point(129, 267);
            this.btn_return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(98, 40);
            this.btn_return.TabIndex = 45;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click_1);
            // 
            // lbl_Item_Id
            // 
            this.lbl_Item_Id.AutoSize = true;
            this.lbl_Item_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_Item_Id.Location = new System.Drawing.Point(74, 18);
            this.lbl_Item_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Item_Id.Name = "lbl_Item_Id";
            this.lbl_Item_Id.Size = new System.Drawing.Size(91, 17);
            this.lbl_Item_Id.TabIndex = 44;
            this.lbl_Item_Id.Text = "lbl_EditItemId";
            // 
            // btn_EditStockBtn
            // 
            this.btn_EditStockBtn.ForeColor = System.Drawing.Color.Black;
            this.btn_EditStockBtn.Location = new System.Drawing.Point(10, 267);
            this.btn_EditStockBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_EditStockBtn.Name = "btn_EditStockBtn";
            this.btn_EditStockBtn.Size = new System.Drawing.Size(98, 40);
            this.btn_EditStockBtn.TabIndex = 43;
            this.btn_EditStockBtn.Text = "Edit Stock";
            this.btn_EditStockBtn.UseVisualStyleBackColor = true;
            this.btn_EditStockBtn.Click += new System.EventHandler(this.btn_EditStockBtn_Click_1);
            // 
            // tb_editItemName
            // 
            this.tb_editItemName.Location = new System.Drawing.Point(100, 50);
            this.tb_editItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_editItemName.Name = "tb_editItemName";
            this.tb_editItemName.Size = new System.Drawing.Size(130, 20);
            this.tb_editItemName.TabIndex = 36;
            // 
            // tb_editInfo
            // 
            this.tb_editInfo.Location = new System.Drawing.Point(44, 128);
            this.tb_editInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_editInfo.Multiline = true;
            this.tb_editInfo.Name = "tb_editInfo";
            this.tb_editInfo.Size = new System.Drawing.Size(186, 71);
            this.tb_editInfo.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(4, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Price:";
            // 
            // tb_editPrice
            // 
            this.tb_editPrice.Location = new System.Drawing.Point(100, 84);
            this.tb_editPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_editPrice.Name = "tb_editPrice";
            this.tb_editPrice.Size = new System.Drawing.Size(130, 20);
            this.tb_editPrice.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(7, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Info:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(4, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Item Name";
            // 
            // cb_editCategory
            // 
            this.cb_editCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_editCategory.FormattingEnabled = true;
            this.cb_editCategory.Items.AddRange(new object[] {
            "LAPTOPS",
            "HEADPHONES",
            "MOUSES",
            "KEYBOARDS"});
            this.cb_editCategory.Location = new System.Drawing.Point(100, 224);
            this.cb_editCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_editCategory.Name = "cb_editCategory";
            this.cb_editCategory.Size = new System.Drawing.Size(130, 21);
            this.cb_editCategory.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(4, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Category:";
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1048, 480);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.tc_AddAndEdit);
            this.Controls.Add(this.lblLoggedInUserRole);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.btnDepMenu);
            this.Controls.Add(this.btnStckMenu);
            this.Controls.Add(this.btnEmpMenu);
            this.Controls.Add(this.btnHomeMenu);
            this.MinimumSize = new System.Drawing.Size(1064, 519);
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tc_AddAndEdit.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDepMenu;
        private System.Windows.Forms.Button btnStckMenu;
        private System.Windows.Forms.Button btnEmpMenu;
        private System.Windows.Forms.Button btnHomeMenu;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLoggedInUserRole;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumQuantity;
        private System.Windows.Forms.TabControl tc_AddAndEdit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbMaxQuantity;
        private System.Windows.Forms.Label lbl_MaxQuantity;
        private System.Windows.Forms.Button btn_EditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMinQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInStoreAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lbl_Item_Id;
        private System.Windows.Forms.Button btn_EditStockBtn;
        private System.Windows.Forms.TextBox tb_editItemName;
        private System.Windows.Forms.TextBox tb_editInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_editPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_editCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_AddToStore;
        private System.Windows.Forms.TextBox tb_AmountToStore;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.TextBox tb_AmountRestocked;
    }
}