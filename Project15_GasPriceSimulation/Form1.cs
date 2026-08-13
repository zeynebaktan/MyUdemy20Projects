using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dieselPrice = 82.37;
        double gasolinePrice = 72.06;
        double lpgPrice = 34.39;
        double GasAmount = 0;
        double DieselAmount = 0;
        double LpgAmount = 0;
        double totalPrice = 0;
        int count = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            GasAmount = Convert.ToDouble(txtGasAmount.Text);
            DieselAmount = Convert.ToDouble(txtGasAmount.Text);
            LpgAmount = Convert.ToDouble(txtGasAmount.Text);
            timer1.Start();
            timer1.Interval = 100; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = count.ToString();
            if (rdbGasoline.Checked)
            {
                count++;
                if (count <= GasAmount)
                {
                    totalPrice += gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";

                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString();
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }

            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= GasAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";

                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString();
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }

            if (rdbLpg.Checked)
            {
                count++;
                if (count <= LpgAmount)
                {
                    totalPrice += lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";

                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString();
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Api Yakıt Veriileri Alınıyor...");

            txtDieselPrice.Text = dieselPrice.ToString() + " ₺";
            txtGasolinePrice.Text = gasolinePrice.ToString() + " ₺";
            txtLpgPrice.Text = lpgPrice.ToString() + " ₺";
        }
    }
}
