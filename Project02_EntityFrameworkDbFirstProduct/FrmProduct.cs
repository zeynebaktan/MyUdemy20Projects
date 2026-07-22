using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02_EntityFrameworkDbFirstProduct
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        Db2Project20Entities db = new Db2Project20Entities();
        void ProductList()
        {
            dataGridView1.DataSource = db.TblProduct.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        }
    }
}
