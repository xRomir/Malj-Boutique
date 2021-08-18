namespace Malj_Boutique
{
    partial class login
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonFunc = new System.Windows.Forms.Button();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonPos = new System.Windows.Forms.RadioButton();
            this.radioButtonInv = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(107, 115);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(182, 20);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 141);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // buttonFunc
            // 
            this.buttonFunc.Location = new System.Drawing.Point(107, 167);
            this.buttonFunc.Name = "buttonFunc";
            this.buttonFunc.Size = new System.Drawing.Size(182, 23);
            this.buttonFunc.TabIndex = 2;
            this.buttonFunc.Text = "button1";
            this.buttonFunc.UseVisualStyleBackColor = true;
            this.buttonFunc.Click += new System.EventHandler(this.buttonFunc_Click);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(77, 196);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(77, 24);
            this.radioButtonAdmin.TabIndex = 3;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = false;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonPos
            // 
            this.radioButtonPos.AutoSize = true;
            this.radioButtonPos.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPos.Location = new System.Drawing.Point(160, 196);
            this.radioButtonPos.Name = "radioButtonPos";
            this.radioButtonPos.Size = new System.Drawing.Size(63, 24);
            this.radioButtonPos.TabIndex = 4;
            this.radioButtonPos.TabStop = true;
            this.radioButtonPos.Text = "POS";
            this.radioButtonPos.UseVisualStyleBackColor = false;
            this.radioButtonPos.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonInv
            // 
            this.radioButtonInv.AutoSize = true;
            this.radioButtonInv.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInv.Location = new System.Drawing.Point(229, 196);
            this.radioButtonInv.Name = "radioButtonInv";
            this.radioButtonInv.Size = new System.Drawing.Size(101, 24);
            this.radioButtonInv.TabIndex = 5;
            this.radioButtonInv.TabStop = true;
            this.radioButtonInv.Text = "Inventory";
            this.radioButtonInv.UseVisualStyleBackColor = false;
            this.radioButtonInv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Script", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(29, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(356, 67);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Malj\'s Boutique";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password: ";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Malj_Boutique.Properties.Resources.abstract_blurred_fashion_clothes_shop_260nw_1369671731;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.radioButtonInv);
            this.Controls.Add(this.radioButtonPos);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.buttonFunc);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonFunc;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonPos;
        private System.Windows.Forms.RadioButton radioButtonInv;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}