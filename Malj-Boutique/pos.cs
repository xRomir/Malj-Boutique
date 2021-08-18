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
    public partial class pos : Form
    {
        public pos()
        {
            InitializeComponent();
        }

        private void pos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dataDataSet.items);

            itemPrice = 56;

        }

        public int itemPrice;
        public int totalPrice;
        public int change;
        public int stocks;
        public int endstock;
        public int itemid;

        public string constr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\users\user\documents\visual studio 2015\Projects\Malj-Boutique\Malj-Boutique\Data.mdb";

        private void comboBoxPurchaseItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAmmounts();
        }

        private void getAmmounts()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT * FROM [items] WHERE [itemName] = '" + comboBoxPurchaseItem.Text.Trim() + "'";
                cmd.Connection = con;
                con.Open();
                OleDbDataReader r1 = cmd.ExecuteReader();
                r1.Read();

                textBoxPurchaseDesc.Text = r1["itemDescription"].ToString();
                itemPrice = Convert.ToInt32(r1["itemPrice"].ToString());
                totalPrice = (Convert.ToInt32(textBoxPurchaseAmount.Text.Trim()) * itemPrice);
                textBoxTotal.Text = "$" + totalPrice.ToString().Trim();
                change = Convert.ToInt32(textBoxCash.Text.Trim()) - totalPrice;
                textBoxChange.Text = "$" + change.ToString().Trim();
                stocks = Convert.ToInt32(r1["stock"].ToString());
                endstock = stocks - Convert.ToInt32(textBoxPurchaseAmount.Text.Trim());
                itemid = Convert.ToInt32(r1["itemID"].ToString());

                r1.Close();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void textBoxCash_Click(object sender, EventArgs e)
        {
            textBoxCash.Text = "";
        }

        private void textBoxCash_TextChanged(object sender, EventArgs e)
        {
            getAmmounts();
        }

        private void textBoxPurchaseAmount_TextChanged(object sender, EventArgs e)
        {
            getAmmounts();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (change < 0)
            {
                MessageBox.Show("Cash is insufficient! Please enter a valid amount.", "Inssuficient Payment!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (endstock < 0)
                {
                    MessageBox.Show("Cannot provide enough stocks!.", "Few Stocks!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "UPDATE items SET items.stock = " + endstock + " WHERE (((items.itemID)=" + itemid + "));";
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Purchase successful!.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
