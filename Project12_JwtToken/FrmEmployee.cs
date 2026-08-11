using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server= DESKTOP-81KICDV; initial catalog=Db12Project20; integrated security=true");

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            //if(yetki)
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblEmployee", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
            //else
            //MesaggeBox.Show("Yetkiniz yoktur. Token oluşturmak için giriş yapınız.");
        }
    }
}
