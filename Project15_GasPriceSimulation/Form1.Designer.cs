namespace Project15_GasPriceSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGasAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGasolinePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDieselPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLpgPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbGasoline = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDiesel = new System.Windows.Forms.RadioButton();
            this.rdbLpg = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gas Price Simulation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yakıt Miktarı:";
            // 
            // txtGasAmount
            // 
            this.txtGasAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtGasAmount.Location = new System.Drawing.Point(159, 85);
            this.txtGasAmount.Name = "txtGasAmount";
            this.txtGasAmount.Size = new System.Drawing.Size(227, 30);
            this.txtGasAmount.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtTotalPrice.Location = new System.Drawing.Point(159, 121);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(227, 30);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dolum Durumu:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(159, 157);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 30);
            this.progressBar1.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnStart.Location = new System.Drawing.Point(159, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 42);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "İşlemi Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLpgPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDieselPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGasolinePrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(640, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyatlar:";
            // 
            // txtGasolinePrice
            // 
            this.txtGasolinePrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtGasolinePrice.Location = new System.Drawing.Point(106, 31);
            this.txtGasolinePrice.Name = "txtGasolinePrice";
            this.txtGasolinePrice.ReadOnly = true;
            this.txtGasolinePrice.Size = new System.Drawing.Size(136, 30);
            this.txtGasolinePrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Benzin:";
            // 
            // txtDieselPrice
            // 
            this.txtDieselPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtDieselPrice.Location = new System.Drawing.Point(106, 67);
            this.txtDieselPrice.Name = "txtDieselPrice";
            this.txtDieselPrice.ReadOnly = true;
            this.txtDieselPrice.Size = new System.Drawing.Size(136, 30);
            this.txtDieselPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motorin:";
            // 
            // txtLpgPrice
            // 
            this.txtLpgPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtLpgPrice.Location = new System.Drawing.Point(106, 103);
            this.txtLpgPrice.Name = "txtLpgPrice";
            this.txtLpgPrice.ReadOnly = true;
            this.txtLpgPrice.Size = new System.Drawing.Size(136, 30);
            this.txtLpgPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lpg:";
            // 
            // rdbGasoline
            // 
            this.rdbGasoline.AutoSize = true;
            this.rdbGasoline.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.rdbGasoline.Location = new System.Drawing.Point(6, 39);
            this.rdbGasoline.Name = "rdbGasoline";
            this.rdbGasoline.Size = new System.Drawing.Size(82, 27);
            this.rdbGasoline.TabIndex = 9;
            this.rdbGasoline.TabStop = true;
            this.rdbGasoline.Text = "Benzin";
            this.rdbGasoline.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLpg);
            this.groupBox2.Controls.Add(this.rdbDiesel);
            this.groupBox2.Controls.Add(this.rdbGasoline);
            this.groupBox2.Location = new System.Drawing.Point(640, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 99);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yakıt Türü:";
            // 
            // rdbDiesel
            // 
            this.rdbDiesel.AutoSize = true;
            this.rdbDiesel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.rdbDiesel.Location = new System.Drawing.Point(94, 39);
            this.rdbDiesel.Name = "rdbDiesel";
            this.rdbDiesel.Size = new System.Drawing.Size(92, 27);
            this.rdbDiesel.TabIndex = 10;
            this.rdbDiesel.TabStop = true;
            this.rdbDiesel.Text = "Motorin";
            this.rdbDiesel.UseVisualStyleBackColor = true;
            // 
            // rdbLpg
            // 
            this.rdbLpg.AutoSize = true;
            this.rdbLpg.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.rdbLpg.Location = new System.Drawing.Point(192, 39);
            this.rdbLpg.Name = "rdbLpg";
            this.rdbLpg.Size = new System.Drawing.Size(61, 27);
            this.rdbLpg.TabIndex = 11;
            this.rdbLpg.TabStop = true;
            this.rdbLpg.Text = "LPG";
            this.rdbLpg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(241)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(952, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGasAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGasAmount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLpgPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDieselPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGasolinePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbGasoline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLpg;
        private System.Windows.Forms.RadioButton rdbDiesel;
    }
}

