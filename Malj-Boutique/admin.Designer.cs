namespace Malj_Boutique
{
    partial class admin
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
            this.groupBoxUsermngmnt = new System.Windows.Forms.GroupBox();
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonOpenAddItem = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAddInv = new System.Windows.Forms.CheckBox();
            this.checkBoxAddPos = new System.Windows.Forms.CheckBox();
            this.textBoxAddPass = new System.Windows.Forms.TextBox();
            this.textBoxAddFull = new System.Windows.Forms.TextBox();
            this.textBoxAddUser = new System.Windows.Forms.TextBox();
            this.groupBoxEditUser = new System.Windows.Forms.GroupBox();
            this.comboBoxUsername = new System.Windows.Forms.ComboBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new Malj_Boutique.DataDataSet();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxEditInv = new System.Windows.Forms.CheckBox();
            this.checkBoxEditPos = new System.Windows.Forms.CheckBox();
            this.textBoxEditPass = new System.Windows.Forms.TextBox();
            this.textBoxEditFull = new System.Windows.Forms.TextBox();
            this.itemsTableAdapter = new Malj_Boutique.DataDataSetTableAdapters.itemsTableAdapter();
            this.loginTableAdapter = new Malj_Boutique.DataDataSetTableAdapters.loginTableAdapter();
            this.groupBoxEditItems = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAddItem = new System.Windows.Forms.GroupBox();
            this.textBoxItemDesc = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxItemType = new System.Windows.Forms.TextBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxUsermngmnt.SuspendLayout();
            this.groupBoxAddUser.SuspendLayout();
            this.groupBoxEditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.groupBoxEditItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBoxAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsermngmnt
            // 
            this.groupBoxUsermngmnt.Controls.Add(this.buttonEditItem);
            this.groupBoxUsermngmnt.Controls.Add(this.buttonOpenAddItem);
            this.groupBoxUsermngmnt.Controls.Add(this.buttonEditUser);
            this.groupBoxUsermngmnt.Controls.Add(this.buttonAddUser);
            this.groupBoxUsermngmnt.Location = new System.Drawing.Point(226, 32);
            this.groupBoxUsermngmnt.Name = "groupBoxUsermngmnt";
            this.groupBoxUsermngmnt.Size = new System.Drawing.Size(504, 326);
            this.groupBoxUsermngmnt.TabIndex = 0;
            this.groupBoxUsermngmnt.TabStop = false;
            this.groupBoxUsermngmnt.Text = "User Management";
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.Location = new System.Drawing.Point(325, 126);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(74, 61);
            this.buttonEditItem.TabIndex = 5;
            this.buttonEditItem.Text = "Edit Item Infos";
            this.buttonEditItem.UseVisualStyleBackColor = true;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // buttonOpenAddItem
            // 
            this.buttonOpenAddItem.Location = new System.Drawing.Point(245, 126);
            this.buttonOpenAddItem.Name = "buttonOpenAddItem";
            this.buttonOpenAddItem.Size = new System.Drawing.Size(74, 61);
            this.buttonOpenAddItem.TabIndex = 4;
            this.buttonOpenAddItem.Text = "Add Item";
            this.buttonOpenAddItem.UseVisualStyleBackColor = true;
            this.buttonOpenAddItem.Click += new System.EventHandler(this.buttonOpenAddItem_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(165, 125);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(74, 61);
            this.buttonEditUser.TabIndex = 3;
            this.buttonEditUser.Text = "Edit User Info";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(85, 125);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(74, 61);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.buttonRegisterUser);
            this.groupBoxAddUser.Controls.Add(this.label3);
            this.groupBoxAddUser.Controls.Add(this.label2);
            this.groupBoxAddUser.Controls.Add(this.label1);
            this.groupBoxAddUser.Controls.Add(this.checkBoxAddInv);
            this.groupBoxAddUser.Controls.Add(this.checkBoxAddPos);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddPass);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddFull);
            this.groupBoxAddUser.Controls.Add(this.textBoxAddUser);
            this.groupBoxAddUser.Location = new System.Drawing.Point(865, 291);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(501, 323);
            this.groupBoxAddUser.TabIndex = 1;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Add User";
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonRegisterUser.Location = new System.Drawing.Point(54, 171);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(220, 43);
            this.buttonRegisterUser.TabIndex = 8;
            this.buttonRegisterUser.Text = "Register User";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.buttonRegisterUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fullname: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username: ";
            // 
            // checkBoxAddInv
            // 
            this.checkBoxAddInv.AutoSize = true;
            this.checkBoxAddInv.Location = new System.Drawing.Point(112, 148);
            this.checkBoxAddInv.Name = "checkBoxAddInv";
            this.checkBoxAddInv.Size = new System.Drawing.Size(162, 17);
            this.checkBoxAddInv.TabIndex = 4;
            this.checkBoxAddInv.Text = "Enable Access to Inventory?";
            this.checkBoxAddInv.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddPos
            // 
            this.checkBoxAddPos.AutoSize = true;
            this.checkBoxAddPos.Location = new System.Drawing.Point(112, 125);
            this.checkBoxAddPos.Name = "checkBoxAddPos";
            this.checkBoxAddPos.Size = new System.Drawing.Size(139, 17);
            this.checkBoxAddPos.TabIndex = 3;
            this.checkBoxAddPos.Text = "Enable access to POS?";
            this.checkBoxAddPos.UseVisualStyleBackColor = true;
            // 
            // textBoxAddPass
            // 
            this.textBoxAddPass.Location = new System.Drawing.Point(112, 73);
            this.textBoxAddPass.Name = "textBoxAddPass";
            this.textBoxAddPass.Size = new System.Drawing.Size(139, 20);
            this.textBoxAddPass.TabIndex = 2;
            // 
            // textBoxAddFull
            // 
            this.textBoxAddFull.Location = new System.Drawing.Point(112, 99);
            this.textBoxAddFull.Name = "textBoxAddFull";
            this.textBoxAddFull.Size = new System.Drawing.Size(139, 20);
            this.textBoxAddFull.TabIndex = 1;
            // 
            // textBoxAddUser
            // 
            this.textBoxAddUser.Location = new System.Drawing.Point(112, 47);
            this.textBoxAddUser.Name = "textBoxAddUser";
            this.textBoxAddUser.Size = new System.Drawing.Size(139, 20);
            this.textBoxAddUser.TabIndex = 0;
            // 
            // groupBoxEditUser
            // 
            this.groupBoxEditUser.Controls.Add(this.comboBoxUsername);
            this.groupBoxEditUser.Controls.Add(this.buttonUpdateUser);
            this.groupBoxEditUser.Controls.Add(this.label4);
            this.groupBoxEditUser.Controls.Add(this.label5);
            this.groupBoxEditUser.Controls.Add(this.label6);
            this.groupBoxEditUser.Controls.Add(this.checkBoxEditInv);
            this.groupBoxEditUser.Controls.Add(this.checkBoxEditPos);
            this.groupBoxEditUser.Controls.Add(this.textBoxEditPass);
            this.groupBoxEditUser.Controls.Add(this.textBoxEditFull);
            this.groupBoxEditUser.Location = new System.Drawing.Point(841, 310);
            this.groupBoxEditUser.Name = "groupBoxEditUser";
            this.groupBoxEditUser.Size = new System.Drawing.Size(501, 323);
            this.groupBoxEditUser.TabIndex = 9;
            this.groupBoxEditUser.TabStop = false;
            this.groupBoxEditUser.Text = "Edit User";
            // 
            // comboBoxUsername
            // 
            this.comboBoxUsername.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginBindingSource, "Username", true));
            this.comboBoxUsername.DataSource = this.loginBindingSource;
            this.comboBoxUsername.DisplayMember = "Username";
            this.comboBoxUsername.FormattingEnabled = true;
            this.comboBoxUsername.Location = new System.Drawing.Point(112, 46);
            this.comboBoxUsername.Name = "comboBoxUsername";
            this.comboBoxUsername.Size = new System.Drawing.Size(139, 21);
            this.comboBoxUsername.TabIndex = 9;
            this.comboBoxUsername.ValueMember = "Username";
            this.comboBoxUsername.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsername_SelectedIndexChanged);
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.dataDataSetBindingSource;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonUpdateUser.Location = new System.Drawing.Point(54, 171);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(220, 43);
            this.buttonUpdateUser.TabIndex = 8;
            this.buttonUpdateUser.Text = "Update User";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fullname: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username: ";
            // 
            // checkBoxEditInv
            // 
            this.checkBoxEditInv.AutoSize = true;
            this.checkBoxEditInv.Location = new System.Drawing.Point(112, 148);
            this.checkBoxEditInv.Name = "checkBoxEditInv";
            this.checkBoxEditInv.Size = new System.Drawing.Size(162, 17);
            this.checkBoxEditInv.TabIndex = 4;
            this.checkBoxEditInv.Text = "Enable Access to Inventory?";
            this.checkBoxEditInv.UseVisualStyleBackColor = true;
            // 
            // checkBoxEditPos
            // 
            this.checkBoxEditPos.AutoSize = true;
            this.checkBoxEditPos.Location = new System.Drawing.Point(112, 125);
            this.checkBoxEditPos.Name = "checkBoxEditPos";
            this.checkBoxEditPos.Size = new System.Drawing.Size(139, 17);
            this.checkBoxEditPos.TabIndex = 3;
            this.checkBoxEditPos.Text = "Enable access to POS?";
            this.checkBoxEditPos.UseVisualStyleBackColor = true;
            // 
            // textBoxEditPass
            // 
            this.textBoxEditPass.Location = new System.Drawing.Point(112, 73);
            this.textBoxEditPass.Name = "textBoxEditPass";
            this.textBoxEditPass.PasswordChar = '*';
            this.textBoxEditPass.Size = new System.Drawing.Size(139, 20);
            this.textBoxEditPass.TabIndex = 2;
            // 
            // textBoxEditFull
            // 
            this.textBoxEditFull.Location = new System.Drawing.Point(112, 99);
            this.textBoxEditFull.Name = "textBoxEditFull";
            this.textBoxEditFull.Size = new System.Drawing.Size(139, 20);
            this.textBoxEditFull.TabIndex = 1;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxEditItems
            // 
            this.groupBoxEditItems.Controls.Add(this.dataGridView1);
            this.groupBoxEditItems.Location = new System.Drawing.Point(138, 364);
            this.groupBoxEditItems.Name = "groupBoxEditItems";
            this.groupBoxEditItems.Size = new System.Drawing.Size(650, 320);
            this.groupBoxEditItems.TabIndex = 10;
            this.groupBoxEditItems.TabStop = false;
            this.groupBoxEditItems.Text = "Edit Item Infos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.stock});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "itemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "itemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "itemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "itemType";
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "itemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "itemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "itemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.dataDataSetBindingSource;
            // 
            // groupBoxAddItem
            // 
            this.groupBoxAddItem.Controls.Add(this.textBoxItemDesc);
            this.groupBoxAddItem.Controls.Add(this.textBoxItemName);
            this.groupBoxAddItem.Controls.Add(this.label10);
            this.groupBoxAddItem.Controls.Add(this.buttonAddItem);
            this.groupBoxAddItem.Controls.Add(this.label7);
            this.groupBoxAddItem.Controls.Add(this.label8);
            this.groupBoxAddItem.Controls.Add(this.label9);
            this.groupBoxAddItem.Controls.Add(this.textBoxItemType);
            this.groupBoxAddItem.Controls.Add(this.textBoxItemPrice);
            this.groupBoxAddItem.Location = new System.Drawing.Point(895, 247);
            this.groupBoxAddItem.Name = "groupBoxAddItem";
            this.groupBoxAddItem.Size = new System.Drawing.Size(501, 323);
            this.groupBoxAddItem.TabIndex = 11;
            this.groupBoxAddItem.TabStop = false;
            this.groupBoxAddItem.Text = "Edit User";
            // 
            // textBoxItemDesc
            // 
            this.textBoxItemDesc.Location = new System.Drawing.Point(137, 153);
            this.textBoxItemDesc.Multiline = true;
            this.textBoxItemDesc.Name = "textBoxItemDesc";
            this.textBoxItemDesc.Size = new System.Drawing.Size(220, 57);
            this.textBoxItemDesc.TabIndex = 13;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(137, 75);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.PasswordChar = '*';
            this.textBoxItemName.Size = new System.Drawing.Size(220, 20);
            this.textBoxItemName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Description: ";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAddItem.Location = new System.Drawing.Point(137, 216);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(220, 43);
            this.buttonAddItem.TabIndex = 8;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Price(in dollars): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Name: ";
            // 
            // textBoxItemType
            // 
            this.textBoxItemType.Location = new System.Drawing.Point(137, 101);
            this.textBoxItemType.Name = "textBoxItemType";
            this.textBoxItemType.PasswordChar = '*';
            this.textBoxItemType.Size = new System.Drawing.Size(220, 20);
            this.textBoxItemType.TabIndex = 2;
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Location = new System.Drawing.Point(137, 127);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(220, 20);
            this.textBoxItemPrice.TabIndex = 1;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(74, 39);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 391);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxAddItem);
            this.Controls.Add(this.groupBoxEditItems);
            this.Controls.Add(this.groupBoxEditUser);
            this.Controls.Add(this.groupBoxAddUser);
            this.Controls.Add(this.groupBoxUsermngmnt);
            this.Name = "admin";
            this.Text = "Administrator Controls";
            this.Load += new System.EventHandler(this.admin_Load);
            this.groupBoxUsermngmnt.ResumeLayout(false);
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            this.groupBoxEditUser.ResumeLayout(false);
            this.groupBoxEditUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.groupBoxEditItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBoxAddItem.ResumeLayout(false);
            this.groupBoxAddItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsermngmnt;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAddInv;
        private System.Windows.Forms.CheckBox checkBoxAddPos;
        private System.Windows.Forms.TextBox textBoxAddPass;
        private System.Windows.Forms.TextBox textBoxAddFull;
        private System.Windows.Forms.TextBox textBoxAddUser;
        private System.Windows.Forms.GroupBox groupBoxEditUser;
        private System.Windows.Forms.ComboBox comboBoxUsername;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxEditInv;
        private System.Windows.Forms.CheckBox checkBoxEditPos;
        private System.Windows.Forms.TextBox textBoxEditPass;
        private System.Windows.Forms.TextBox textBoxEditFull;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private DataDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private DataDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Button buttonOpenAddItem;
        private System.Windows.Forms.GroupBox groupBoxEditItems;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.GroupBox groupBoxAddItem;
        private System.Windows.Forms.TextBox textBoxItemDesc;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxItemType;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Button buttonBack;
    }
}