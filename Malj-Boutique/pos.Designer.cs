namespace Malj_Boutique
{
    partial class pos
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
            this.comboBoxPurchaseItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDataSet = new Malj_Boutique.DataDataSet();
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Malj_Boutique.DataDataSetTableAdapters.itemsTableAdapter();
            this.textBoxPurchaseDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPurchaseAmount = new System.Windows.Forms.TextBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPurchaseItem
            // 
            this.comboBoxPurchaseItem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "itemName", true));
            this.comboBoxPurchaseItem.DataSource = this.itemsBindingSource;
            this.comboBoxPurchaseItem.DisplayMember = "itemName";
            this.comboBoxPurchaseItem.FormattingEnabled = true;
            this.comboBoxPurchaseItem.Location = new System.Drawing.Point(130, 53);
            this.comboBoxPurchaseItem.Name = "comboBoxPurchaseItem";
            this.comboBoxPurchaseItem.Size = new System.Drawing.Size(180, 21);
            this.comboBoxPurchaseItem.TabIndex = 0;
            this.comboBoxPurchaseItem.ValueMember = "itemName";
            this.comboBoxPurchaseItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxPurchaseItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Item:";
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.dataDataSetBindingSource;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPurchaseDesc
            // 
            this.textBoxPurchaseDesc.Enabled = false;
            this.textBoxPurchaseDesc.Location = new System.Drawing.Point(130, 99);
            this.textBoxPurchaseDesc.Multiline = true;
            this.textBoxPurchaseDesc.Name = "textBoxPurchaseDesc";
            this.textBoxPurchaseDesc.Size = new System.Drawing.Size(180, 66);
            this.textBoxPurchaseDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Qty:";
            // 
            // textBoxPurchaseAmount
            // 
            this.textBoxPurchaseAmount.Location = new System.Drawing.Point(316, 53);
            this.textBoxPurchaseAmount.Name = "textBoxPurchaseAmount";
            this.textBoxPurchaseAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxPurchaseAmount.TabIndex = 4;
            this.textBoxPurchaseAmount.Text = "0";
            this.textBoxPurchaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPurchaseAmount.TextChanged += new System.EventHandler(this.textBoxPurchaseAmount_TextChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(316, 125);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(206, 40);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Purchase";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Description: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Change: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cash:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(316, 99);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 13;
            this.textBoxTotal.Text = "$0.00";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxChange
            // 
            this.textBoxChange.Enabled = false;
            this.textBoxChange.Location = new System.Drawing.Point(422, 100);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(100, 20);
            this.textBoxChange.TabIndex = 15;
            this.textBoxChange.Text = "$0.00";
            this.textBoxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(422, 54);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxCash.TabIndex = 14;
            this.textBoxCash.Text = "0";
            this.textBoxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCash.Click += new System.EventHandler(this.textBoxCash_Click);
            this.textBoxCash.TextChanged += new System.EventHandler(this.textBoxCash_TextChanged);
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 197);
            this.Controls.Add(this.textBoxChange);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.textBoxPurchaseAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPurchaseDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPurchaseItem);
            this.Name = "pos";
            this.Text = "Purchase Item";
            this.Load += new System.EventHandler(this.pos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPurchaseItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DataDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox textBoxPurchaseDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPurchaseAmount;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.TextBox textBoxCash;
    }
}