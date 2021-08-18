using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malj_Boutique
{
    public partial class inv : Form
    {
        public inv()
        {
            InitializeComponent();
        }

        private void inv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dataDataSet.items);

        }
    }
}
