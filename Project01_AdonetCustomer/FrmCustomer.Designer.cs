namespace Project01_AdonetCustomer
{
    partial class FrmCustomer
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbPasive = new System.Windows.Forms.RadioButton();
            this.btnProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCustomerName.Location = new System.Drawing.Point(130, 50);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(243, 22);
            this.txtCustomerName.TabIndex = 28;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCustomerId.Location = new System.Drawing.Point(130, 22);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(243, 22);
            this.txtCustomerId.TabIndex = 27;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCreate.Location = new System.Drawing.Point(130, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(243, 36);
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Text = "Ekle:";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDelete.Location = new System.Drawing.Point(131, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(243, 36);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Sil:";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSearch.Location = new System.Drawing.Point(130, 369);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(243, 36);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Ara:";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnUpdate.Location = new System.Drawing.Point(130, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(243, 36);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Güncelle:";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnList.Location = new System.Drawing.Point(131, 201);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(120, 36);
            this.btnList.TabIndex = 21;
            this.btnList.Text = "Listele:";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Müşteri Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 383);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Müşteri id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(78, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Şehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(70, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Durum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(66, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bakiye:";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtBalance.Location = new System.Drawing.Point(130, 106);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(243, 22);
            this.txtBalance.TabIndex = 34;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.LavenderBlush;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(130, 134);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(244, 24);
            this.cmbCity.TabIndex = 35;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCustomerSurname.Location = new System.Drawing.Point(131, 78);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(243, 22);
            this.txtCustomerSurname.TabIndex = 26;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(131, 166);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(53, 20);
            this.rdbActive.TabIndex = 36;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "Aktif";
            this.rdbActive.UseVisualStyleBackColor = true;
            this.rdbActive.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbPasive
            // 
            this.rdbPasive.AutoSize = true;
            this.rdbPasive.Location = new System.Drawing.Point(199, 166);
            this.rdbPasive.Name = "rdbPasive";
            this.rdbPasive.Size = new System.Drawing.Size(58, 20);
            this.rdbPasive.TabIndex = 37;
            this.rdbPasive.TabStop = true;
            this.rdbPasive.Text = "Pasif";
            this.rdbPasive.UseVisualStyleBackColor = true;
            // 
            // btnProcedure
            // 
            this.btnProcedure.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnProcedure.Location = new System.Drawing.Point(257, 201);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(117, 36);
            this.btnProcedure.TabIndex = 38;
            this.btnProcedure.Text = "Prosedür";
            this.btnProcedure.UseVisualStyleBackColor = false;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1114, 432);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.rdbPasive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.Text = "Müşteri Formu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbPasive;
        private System.Windows.Forms.Button btnProcedure;
    }
}