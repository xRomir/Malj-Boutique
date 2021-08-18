using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malj_Boutique
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            buttonFunc.Text = "Login";
            radioButtonInv.Select();
            textBoxUsername.Focus();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            string username, password;

            username = textBoxUsername.Text.Trim();
            password = textBoxPassword.Text.Trim();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked == true)
            {
                openform = "admin";
            }
            if (radioButtonPos.Checked == true)
            {
                openform = "pos";
            }
            if (radioButtonInv.Checked == true)
            {
                openform = "inv";
            }
        }

        public string openform;

        private void buttonFunc_Click(object sender, EventArgs e)
        {
            string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\users\user\documents\visual studio 2015\Projects\Malj-Boutique\Malj-Boutique\Data.mdb";
            OleDbConnection con = new OleDbConnection(constr);

            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "SELECT * FROM [login] WHERE [Username] = '" + textBoxUsername.Text + "' AND [Password] = '" + textBoxPassword.Text + "'";
            con.Open();
            OleDbDataReader r1 = cmd1.ExecuteReader();

            if (r1.Read())
            {
                Form f1;
                if (radioButtonAdmin.Checked == true)
                {
                    f1 = new admin();
                }
                else if (radioButtonInv.Checked == true)
                {
                    f1 = new inv();
                }
                else if (radioButtonPos.Checked == true)
                {
                    f1 = new pos();
                }
                else
                {
                    f1 = new login();
                }
                f1.Show();
                MessageBox.Show("Welcome " + r1["Fullname"].ToString() + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("User does not exist!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.Close();


            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\users\user\documents\visual studio 2015\Projects\Malj-Boutique\Malj-Boutique\Data.mdb;Persist Security Info=True
        }
    }
}
