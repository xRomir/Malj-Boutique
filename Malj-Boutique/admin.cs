using System;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Malj_Boutique
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            loginTableAdapter.Fill(dataDataSet.login);
            itemsTableAdapter.Fill(dataDataSet.items);

            fillInfo("malj");

            Size s1 = new Size(650, 320);
            Size s2 = new Size(690, 430);

            Size = s2;

            groupBoxAddItem.Size = s1;
            groupBoxAddUser.Size = s1;
            groupBoxEditUser.Size = s1;
            groupBoxUsermngmnt.Size = s1;
            groupBoxEditItems.Size = s1;

            Point p1 = new Point(10, 60);

            groupBoxAddItem.Location = p1;
            groupBoxAddUser.Location = p1;
            groupBoxEditUser.Location = p1;
            groupBoxUsermngmnt.Location = p1;
            groupBoxEditItems.Location = p1;

            backed();
        }

        private void backed()
        {
            groupBoxAddItem.Visible = false;
            groupBoxAddUser.Visible = false;
            groupBoxEditUser.Visible = false;
            groupBoxUsermngmnt.Visible = false;
            groupBoxEditItems.Visible = false;
            buttonBack.Visible = false;

            groupBoxUsermngmnt.Visible = true;
        }

        private void comboBoxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillInfo(comboBoxUsername.Text.Trim());
        }

        public string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\users\user\documents\visual studio 2015\Projects\Malj-Boutique\Malj-Boutique\Data.mdb";

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand cmd = new OleDbCommand();
                string s1 = "0", s2 = "0";

                if (checkBoxEditPos.Checked)
                {
                    s1 = "1";
                }
                if (!checkBoxEditPos.Checked)
                {
                    s1 = "0";
                }
                if (checkBoxEditInv.Checked)
                {
                    s2 = "1";
                }
                if (!checkBoxEditInv.Checked)
                {
                    s2 = "0";
                }

                cmd.CommandText = "UPDATE [login] SET [Password] = '" + textBoxEditPass.Text.Trim() + "', [Fullname] = '" + textBoxEditFull.Text.Trim() + "', [pos] = '" + s1 + "', [inv] = '" + s2 + "' WHERE [Username] = '" + comboBoxUsername.Text.Trim() + "'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        protected void fillInfo(string uname)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * FROM [login] WHERE [Username] = '" + uname + "'";
                cmd.Connection = con;
                con.Open();
                OleDbDataReader r1 = cmd.ExecuteReader();
                r1.Read();

                textBoxEditPass.Text = r1["Password"].ToString();
                textBoxEditFull.Text = r1["Fullname"].ToString();
                if (r1["inv"].ToString() == "1")
                {
                    checkBoxEditInv.Checked = true;
                }
                if (r1["inv"].ToString() == "0")
                {
                    checkBoxEditInv.Checked = false;
                }
                if (r1["pos"].ToString() == "1")
                {
                    checkBoxEditPos.Checked = true;
                }
                if (r1["pos"].ToString() == "0")
                {
                    checkBoxEditPos.Checked = false;
                }
                r1.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand cmd = new OleDbCommand();
                string s1 = "0", s2 = "0";
                if (checkBoxAddInv.Checked)
                {
                    s1 = "1";
                }
                if (!checkBoxAddInv.Checked)
                {
                    s1 = "0";
                }
                if (checkBoxAddPos.Checked)
                {
                    s2 = "1";
                }
                if (!checkBoxAddPos.Checked)
                {
                    s2 = "0";
                }
                cmd.CommandText = "INSERT INTO [login] ([Username],[Password],[Fullname],[inv],[pos]) VALUES ('" + textBoxAddUser.Text.Trim() + "','" + textBoxAddPass.Text.Trim() + "','" + textBoxAddFull.Text.Trim() + "','" + s1 + "','" + s2 + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                itemsTableAdapter.Fill(dataDataSet.items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO [items] ([itemName], [itemType], [itemPrice], [itemDescription]) VALUES ('" + textBoxItemName.Text.Trim() + "','" + textBoxItemType.Text.Trim() + "','" + textBoxItemPrice.Text.Trim() + "','" + textBoxItemDesc.Text.Trim() + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                ClearTextBoxes();
            }
            catch (Exception)
            {

            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            groupBoxUsermngmnt.Visible = false;
            groupBoxAddUser.Visible = true;
            buttonBack.Visible = true;
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            groupBoxUsermngmnt.Visible = false;
            groupBoxEditUser.Visible = true;
            buttonBack.Visible = true;
        }

        private void buttonOpenAddItem_Click(object sender, EventArgs e)
        {
            groupBoxUsermngmnt.Visible = false;
            groupBoxAddItem.Visible = true;
            buttonBack.Visible = true;
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            groupBoxUsermngmnt.Visible = false;
            groupBoxEditItems.Visible = true;
            buttonBack.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            backed();
        }
    }
}
