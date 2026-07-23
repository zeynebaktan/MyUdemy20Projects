using System;
using System.Linq;
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

        Db2Project20Entities1 db = new Db2Project20Entities1();
        void ProductList()
        {
            dataGridView1.DataSource = db.TblProduct.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            tblProduct.ProductPrice = decimal.Parse (txtProductPrice.Text);
            tblProduct.ProductStock = int.Parse (txtProductStock.Text);
            tblProduct.ProductName = txtProductName.Text;
            tblProduct.CategoryId = int.Parse (cmbProductCategory.SelectedValue.ToString());
            db.TblProduct.Add(tblProduct);
            db.SaveChanges();
            ProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            db.TblProduct.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProduct.Find(int.Parse(txtProductId.Text));
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.ProductName = txtProductName.Text;
            value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategory.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = values;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = db.TblProduct.Where(x => x.ProductName == txtProductName.Text).ToList();
            dataGridView1.DataSource = values;
        }
    }

}

