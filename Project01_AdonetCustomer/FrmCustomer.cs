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
            SqlCommand command = new SqlCommand("Select CustomerName, CustomerSurname, CustomerBalance, CustomerStatus,CityName From \r\nTblCustomer Inner Join TblCity on TblCity.CityId =TblCustomer.CustomerCity", sqlConnection);
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
            command.Parameters.AddWithValue("@CustomerSurName", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@CustomerCity", cmbCity.SelectedValue);
            command.Parameters.AddWithValue("@CustomerBalance", txtBalance.Text);

            if (rdbActive.Checked)
            {
                command.Parameters.AddWithValue("@CustomerStatus", true);
            }

            if (rdbPasive.Checked)
            {
                command.Parameters.AddWithValue("@CustomerStatus", true);
            }

            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri başarıyla eklendi.");
        }
    }
}
