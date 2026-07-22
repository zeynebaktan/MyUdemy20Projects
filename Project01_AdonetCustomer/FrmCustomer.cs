using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01_AdonetCustomer
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        SqlConnection sqlConnection = new SqlConnection("Server= DESKTOP-81KICDV; initial catalog=DbCustomer; integrated security=true");

        private void btnList_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCustomer", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Execute CustomerListWİthCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCity.ValueMember = "CityId";
            cmbCity.DisplayMember = "CityName";        
            cmbCity.DataSource = dataTable;
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Insert into TblCustomer (CustomerName, CustomerSurname, CustomerBalance, CustomerStatus, CustomerCity) values (@CustomerName, @CustomerSurname, @CustomerBalance, @CustomerStatus, @CustomerCity)", sqlConnection);
            command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@CustomerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@CustomerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@CustomerBalance", txtBalance.Text);

            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@CustomerStatus", true);
            }

            if (rdbPasive.Checked)
            {
                command.Parameters.AddWithValue("@CustomerStatus", false);
            }

            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete From TblCustomer Where CustomerId = @customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri başarıyla silindi.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer Set CustomerName = @customerName, CustomerSurname = @customerSurname, CustomerCity = @customerCity,CustomerBalance = @customerBalance, CustomerStatus = @customerStatus Where CustomerId = @customerId", sqlConnection);
            command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@CustomerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@CustomerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@CustomerId", txtCustomerId.Text);
            command.Parameters.AddWithValue("@CustomerBalance", txtBalance.Text);

            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@CustomerStatus", true);
            }

            if (rdbPasive.Checked)
            {
                command.Parameters.AddWithValue("@CustomerStatus", false);
            }

            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri başarıyla güncellendi.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select CustomerId, CustomerName, CustomerSurname, CustomerBalance, CustomerStatus, CityName From TblCustomer Inner Join TblCity On TblCity.CityId = TblCustomer.CustomerCity Where CustomerName = @customerName", sqlConnection);
            command.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}
