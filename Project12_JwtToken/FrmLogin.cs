using Project12_JwtToken.JWT;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server= DESKTOP-81KICDV; initial catalog=Db12Project20; integrated security=true");

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            
            TokenGenerator tokenGenerator = new TokenGenerator();

            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblUser where Username=@username and Password=@password", sqlConnection);
            command.Parameters.AddWithValue("@username", txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader != null)
            { 
                if (sqlDataReader.Read())
                {
                    string token = tokenGenerator.GenerateJwtToken2(txtUserName.Text);
                    //MessageBox.Show(token);
                    FrmEmployee frm = new FrmEmployee();
                    frm.tokenGet = token;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    txtPassword.Clear();
                    txtUserName.Clear();
                    txtUserName.Focus();
                }

                sqlConnection.Close();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
