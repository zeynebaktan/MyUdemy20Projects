namespace Project14_SQLAllRelation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.db14Project20DataSet = new Project14_SQLAllRelation.Db14Project20DataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new Project14_SQLAllRelation.Db14Project20DataSetTableAdapters.TeamsTableAdapter();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.db14Project20DataSet1 = new Project14_SQLAllRelation.Db14Project20DataSet1();
            this.sponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorsTableAdapter = new Project14_SQLAllRelation.Db14Project20DataSet1TableAdapters.SponsorsTableAdapter();
            this.db14Project20DataSet2 = new Project14_SQLAllRelation.Db14Project20DataSet2();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Project14_SQLAllRelation.Db14Project20DataSet2TableAdapters.PlayersTableAdapter();
            this.pleyerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14Project20DataSet3 = new Project14_SQLAllRelation.Db14Project20DataSet3();
            this.teamSponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamSponsorsTableAdapter = new Project14_SQLAllRelation.Db14Project20DataSet3TableAdapters.TeamSponsorsTableAdapter();
            this.db14Project20DataSet4 = new Project14_SQLAllRelation.Db14Project20DataSet4();
            this.teamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDetailsTableAdapter = new Project14_SQLAllRelation.Db14Project20DataSet4TableAdapters.TeamDetailsTableAdapter();
            this.teamDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14Project20DataSet5 = new Project14_SQLAllRelation.Db14Project20DataSet5();
            this.teamSponsorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamSponsorsTableAdapter1 = new Project14_SQLAllRelation.Db14Project20DataSet5TableAdapters.TeamSponsorsTableAdapter();
            this.teamIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sponsorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db14Project20DataSet6 = new Project14_SQLAllRelation.Db14Project20DataSet6();
            this.sponsorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sponsorsTableAdapter1 = new Project14_SQLAllRelation.Db14Project20DataSet6TableAdapters.SponsorsTableAdapter();
            this.sponsorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sponsorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(96)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamCountryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // db14Project20DataSet
            // 
            this.db14Project20DataSet.DataSetName = "Db14Project20DataSet";
            this.db14Project20DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.db14Project20DataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // teamCountryDataGridViewTextBoxColumn
            // 
            this.teamCountryDataGridViewTextBoxColumn.DataPropertyName = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.HeaderText = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamCountryDataGridViewTextBoxColumn.Name = "teamCountryDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(96)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pleyerIdDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(434, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(416, 236);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(96)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sponsorIdDataGridViewTextBoxColumn1,
            this.sponsorNameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.sponsorsBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(12, 283);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(416, 236);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(96)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDetailIdDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn3,
            this.teamColorDataGridViewTextBoxColumn,
            this.teamCityDataGridViewTextBoxColumn,
            this.teamValueDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.teamDetailsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(856, 41);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(584, 236);
            this.dataGridView4.TabIndex = 3;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(96)))));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn2,
            this.sponsorIdDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.teamSponsorsBindingSource1;
            this.dataGridView5.Location = new System.Drawing.Point(434, 283);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(416, 236);
            this.dataGridView5.TabIndex = 4;
            // 
            // db14Project20DataSet1
            // 
            this.db14Project20DataSet1.DataSetName = "Db14Project20DataSet1";
            this.db14Project20DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorsBindingSource
            // 
            this.sponsorsBindingSource.DataMember = "Sponsors";
            this.sponsorsBindingSource.DataSource = this.db14Project20DataSet1;
            // 
            // sponsorsTableAdapter
            // 
            this.sponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // db14Project20DataSet2
            // 
            this.db14Project20DataSet2.DataSetName = "Db14Project20DataSet2";
            this.db14Project20DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.db14Project20DataSet2;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // pleyerIdDataGridViewTextBoxColumn
            // 
            this.pleyerIdDataGridViewTextBoxColumn.DataPropertyName = "PleyerId";
            this.pleyerIdDataGridViewTextBoxColumn.HeaderText = "PleyerId";
            this.pleyerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pleyerIdDataGridViewTextBoxColumn.Name = "pleyerIdDataGridViewTextBoxColumn";
            this.pleyerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // teamIdDataGridViewTextBoxColumn1
            // 
            this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
            // 
            // db14Project20DataSet3
            // 
            this.db14Project20DataSet3.DataSetName = "Db14Project20DataSet3";
            this.db14Project20DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamSponsorsBindingSource
            // 
            this.teamSponsorsBindingSource.DataMember = "TeamSponsors";
            this.teamSponsorsBindingSource.DataSource = this.db14Project20DataSet3;
            // 
            // teamSponsorsTableAdapter
            // 
            this.teamSponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // db14Project20DataSet4
            // 
            this.db14Project20DataSet4.DataSetName = "Db14Project20DataSet4";
            this.db14Project20DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamDetailsBindingSource
            // 
            this.teamDetailsBindingSource.DataMember = "TeamDetails";
            this.teamDetailsBindingSource.DataSource = this.db14Project20DataSet4;
            // 
            // teamDetailsTableAdapter
            // 
            this.teamDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailIdDataGridViewTextBoxColumn
            // 
            this.teamDetailIdDataGridViewTextBoxColumn.DataPropertyName = "TeamDetailId";
            this.teamDetailIdDataGridViewTextBoxColumn.HeaderText = "TeamDetailId";
            this.teamDetailIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamDetailIdDataGridViewTextBoxColumn.Name = "teamDetailIdDataGridViewTextBoxColumn";
            this.teamDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamIdDataGridViewTextBoxColumn3
            // 
            this.teamIdDataGridViewTextBoxColumn3.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn3.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.teamIdDataGridViewTextBoxColumn3.Name = "teamIdDataGridViewTextBoxColumn3";
            // 
            // teamColorDataGridViewTextBoxColumn
            // 
            this.teamColorDataGridViewTextBoxColumn.DataPropertyName = "TeamColor";
            this.teamColorDataGridViewTextBoxColumn.HeaderText = "TeamColor";
            this.teamColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamColorDataGridViewTextBoxColumn.Name = "teamColorDataGridViewTextBoxColumn";
            // 
            // teamCityDataGridViewTextBoxColumn
            // 
            this.teamCityDataGridViewTextBoxColumn.DataPropertyName = "TeamCity";
            this.teamCityDataGridViewTextBoxColumn.HeaderText = "TeamCity";
            this.teamCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamCityDataGridViewTextBoxColumn.Name = "teamCityDataGridViewTextBoxColumn";
            // 
            // teamValueDataGridViewTextBoxColumn
            // 
            this.teamValueDataGridViewTextBoxColumn.DataPropertyName = "TeamValue";
            this.teamValueDataGridViewTextBoxColumn.HeaderText = "TeamValue";
            this.teamValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teamValueDataGridViewTextBoxColumn.Name = "teamValueDataGridViewTextBoxColumn";
            // 
            // db14Project20DataSet5
            // 
            this.db14Project20DataSet5.DataSetName = "Db14Project20DataSet5";
            this.db14Project20DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamSponsorsBindingSource1
            // 
            this.teamSponsorsBindingSource1.DataMember = "TeamSponsors";
            this.teamSponsorsBindingSource1.DataSource = this.db14Project20DataSet5;
            // 
            // teamSponsorsTableAdapter1
            // 
            this.teamSponsorsTableAdapter1.ClearBeforeFill = true;
            // 
            // teamIdDataGridViewTextBoxColumn2
            // 
            this.teamIdDataGridViewTextBoxColumn2.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.teamIdDataGridViewTextBoxColumn2.Name = "teamIdDataGridViewTextBoxColumn2";
            // 
            // sponsorIdDataGridViewTextBoxColumn
            // 
            this.sponsorIdDataGridViewTextBoxColumn.DataPropertyName = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.HeaderText = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sponsorIdDataGridViewTextBoxColumn.Name = "sponsorIdDataGridViewTextBoxColumn";
            // 
            // db14Project20DataSet6
            // 
            this.db14Project20DataSet6.DataSetName = "Db14Project20DataSet6";
            this.db14Project20DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sponsorsBindingSource1
            // 
            this.sponsorsBindingSource1.DataMember = "Sponsors";
            this.sponsorsBindingSource1.DataSource = this.db14Project20DataSet6;
            // 
            // sponsorsTableAdapter1
            // 
            this.sponsorsTableAdapter1.ClearBeforeFill = true;
            // 
            // sponsorIdDataGridViewTextBoxColumn1
            // 
            this.sponsorIdDataGridViewTextBoxColumn1.DataPropertyName = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn1.HeaderText = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sponsorIdDataGridViewTextBoxColumn1.Name = "sponsorIdDataGridViewTextBoxColumn1";
            this.sponsorIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sponsorNameDataGridViewTextBoxColumn
            // 
            this.sponsorNameDataGridViewTextBoxColumn.DataPropertyName = "SponsorName";
            this.sponsorNameDataGridViewTextBoxColumn.HeaderText = "SponsorName";
            this.sponsorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sponsorNameDataGridViewTextBoxColumn.Name = "sponsorNameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1623, 579);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db14Project20DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sponsorsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Db14Project20DataSet db14Project20DataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private Db14Project20DataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private Db14Project20DataSet1 db14Project20DataSet1;
        private System.Windows.Forms.BindingSource sponsorsBindingSource;
        private Db14Project20DataSet1TableAdapters.SponsorsTableAdapter sponsorsTableAdapter;
        private Db14Project20DataSet2 db14Project20DataSet2;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private Db14Project20DataSet2TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pleyerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
        private Db14Project20DataSet3 db14Project20DataSet3;
        private System.Windows.Forms.BindingSource teamSponsorsBindingSource;
        private Db14Project20DataSet3TableAdapters.TeamSponsorsTableAdapter teamSponsorsTableAdapter;
        private Db14Project20DataSet4 db14Project20DataSet4;
        private System.Windows.Forms.BindingSource teamDetailsBindingSource;
        private Db14Project20DataSet4TableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDetailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamValueDataGridViewTextBoxColumn;
        private Db14Project20DataSet5 db14Project20DataSet5;
        private System.Windows.Forms.BindingSource teamSponsorsBindingSource1;
        private Db14Project20DataSet5TableAdapters.TeamSponsorsTableAdapter teamSponsorsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorIdDataGridViewTextBoxColumn;
        private Db14Project20DataSet6 db14Project20DataSet6;
        private System.Windows.Forms.BindingSource sponsorsBindingSource1;
        private Db14Project20DataSet6TableAdapters.SponsorsTableAdapter sponsorsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorNameDataGridViewTextBoxColumn;
    }
}

