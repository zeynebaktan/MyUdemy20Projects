using Project09_MongoDbOrder.Entities;
using Project09_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project09_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse (txtTotalPrice.Text),
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Ekleme İşlemi Yapıldı.");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
