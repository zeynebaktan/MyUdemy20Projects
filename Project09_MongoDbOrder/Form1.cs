using MongoDB.Bson.Serialization.Serializers;
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
            string orderId = txtId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme İşlemi Yapıldı.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var UpdateOrder = new Order
            {
                OrderId = id,
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            orderOperation.UpdateOrder(UpdateOrder);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Order orders = orderOperation.GetByOrderId(id);
            dataGridView1.DataSource = new List<Order> { orders };
        }
    }
}
