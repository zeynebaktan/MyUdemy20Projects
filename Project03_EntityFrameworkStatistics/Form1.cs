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
            //Toplam kategori sayısı
            int CategoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = CategoryCount.ToString();

            //Toplam ürün sayısı
            int ProductCount = db.TblProduct.Count();
            lblProductCount.Text = ProductCount.ToString();

            //Toplam müşteri sayısı
            int CustomerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = CustomerCount.ToString();

            //Toplam satış sayısı
            int OrderCount = db.TblOrder.Count();
            lblOrderCount.Text = OrderCount.ToString();

            //Toplam stok sayısı
            var TotalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
            lblProductTotalStock.Text = TotalProductStockCount.ToString();

            //Ortalama ürün fiyatı
            var AverageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAveragePrice.Text = AverageProductPrice.ToString() + " ₺";

            //Toplam meyve stoğu sayısı
            var TotalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            lblProductCountByCategoryIsFruit.Text = TotalProductCountByCategoryIsFruit.ToString();

            //Gazoz isimli ürünün toplam işlem hacmi
            var TotalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
            var TotalPriceByProductNameIsGazozUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
            var TotalPriceByProductNameIsGazoz = TotalPriceByProductNameIsGazozGetStock * TotalPriceByProductNameIsGazozUnitPrice;
            lblTotalPriceByProductNameIsGazoz.Text = TotalPriceByProductNameIsGazoz.ToString() + " ₺";

            //Stok sayısı 100'den az olan ürünlerin sayısı
            var ProductCountByStockCountSmallerThan100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductStockSmallerThen100.Text = ProductCountByStockCountSmallerThan100.ToString();

            //Kategorisi sebze ve durumu aktif(true) olan ürün stok toplamı
            int id = db.TblCategory.Where(x => x.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
            var productStockCountByCategoryNameIsSebzeAndStatusTrue = db.TblProduct.Where(x => x.CategoryId == (db.TblCategory.Where(y => y.CategoryName == "Sebze").Select(z => z.CategoryId).FirstOrDefault()) && x.ProductStatus == true).Sum(y => y.ProductStock);
            lblProductCountByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusTrue.ToString();

            //Türkiye'den yapılan siparişler SQL Query
            var OrderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) From TblOrder Where CustomerId In (Select CustomerId From TblCustomer Where CustomerCountry='Türkiye')").FirstOrDefault();
            lblOrderCountFromTurkiyeBySQL.Text = OrderCountFromTurkiye.ToString();

            //Türkiye'den yapılan siparişler EF Metodu
            var TurkishCustomerIds = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye")
                                 .Select(y => y.CustomerId)
                                 .ToList();
            var OrderCountFromTurkiyeWithEF = db.TblOrder.Count(z => TurkishCustomerIds.Contains(z.CustomerId.Value));
            lblOrderCountFromTurkiyeByEF.Text = OrderCountFromTurkiyeWithEF.ToString();

            lblOrderCountFromTurkiyeByEF.Text = OrderCountFromTurkiyeWithEF.ToString();

            //Siparişler içinde kategorisi meyve olan ürünlerin toplam satış fiyatı - SQL Sorgusu
            var orderTotalPriceByCategoryIsMeyve = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) From TblOrder o Join TblProduct p On o.ProductId=p.ProductId Join TblCategory c On p.CategoryId=c.CategoryId Where c.CategoryName='Meyve'").FirstOrDefault();
            lblOrderTotalPriceByCategoryIsMeyve.Text = orderTotalPriceByCategoryIsMeyve.ToString() + " ₺";

            //Siparişler içinde kategorisi meyve olan ürünlerin toplam satış fiyatı - Entity Framework Metodu

            var orderTotalPriceByCategoryIsMeyveWithEF = (from o in db.TblOrder
                                                          join p in db.TblProduct on o.ProductId equals p.ProductId
                                                          join c in db.TblCategory on p.CategoryId equals c.CategoryId
                                                          where c.CategoryName == "Meyve"
                                                          select o.TotalPrice).Sum();
            lblOrderTotalPriceByCategoryIsMeyveByEF.Text = orderTotalPriceByCategoryIsMeyveWithEF.ToString() + " ₺";

            //Son eklenen ürünün adı
            var LastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.ProductName).FirstOrDefault();
            lblLastProductName.Text = LastProductName.ToString();

            //Son eklenen ürünün kategori adı
            var LastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var LastProductCategoryName = db.TblCategory.Where(x => x.CategoryId == LastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
            lblLastProductCategoryName.Text = LastProductCategoryName.ToString();

            //Aktif ürün sayısı
            var ActiveProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
            lblActiveProductCount.Text = ActiveProductCount.ToString();
        }
    }
}
