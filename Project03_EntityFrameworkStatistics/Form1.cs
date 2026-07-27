using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db3Project20Entities db = new Db3Project20Entities();
        private void İstatistikler_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            int CategoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = CategoryCount.ToString();

            //Toplam Ürün Sayısı
            int ProductCount = db.TblProduct.Count();
            lblProductCount.Text = ProductCount.ToString();

            //Toplam Müşteri Sayısı
            int CustomerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = CustomerCount.ToString();

            //Toplam Satış Sayısı
            int OrderCount = db.TblOrder.Count();
            lblOrderCount.Text = OrderCount.ToString();

            //Toplam Stok Sayısı
            var TotalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblProductTotalStock.Text = TotalProductStockCount.ToString();

            //Ortalama Ürün Fiyatı
            var AverageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAveragePrice.Text = AverageProductPrice.ToString() + " ₺";

            //Toplam Meyve Stoğu Sayısı
            var TotalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            lblProductCountByCategoryIsFruit.Text = TotalProductCountByCategoryIsFruit.ToString();

            //Gazoz İsimli Ürünün Toplam İşlem Hacmi
            var TotalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
            var TotalPriceByProductNameIsGazozUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
            var TotalPriceByProductNameIsGazoz = TotalPriceByProductNameIsGazozGetStock * TotalPriceByProductNameIsGazozUnitPrice;
            lblTotalPriceByProductNameIsGazoz.Text = TotalPriceByProductNameIsGazoz.ToString() + " ₺";
        }

    }
}
