using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project14_SQLAllRelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db14Project20DataSet6.Sponsors' table. You can move, or remove it, as needed.
            this.sponsorsTableAdapter1.Fill(this.db14Project20DataSet6.Sponsors);
            // TODO: This line of code loads data into the 'db14Project20DataSet5.TeamSponsors' table. You can move, or remove it, as needed.
            this.teamSponsorsTableAdapter1.Fill(this.db14Project20DataSet5.TeamSponsors);
            // TODO: This line of code loads data into the 'db14Project20DataSet4.TeamDetails' table. You can move, or remove it, as needed.
            this.teamDetailsTableAdapter.Fill(this.db14Project20DataSet4.TeamDetails);
            // TODO: This line of code loads data into the 'db14Project20DataSet3.TeamSponsors' table. You can move, or remove it, as needed.
            this.teamSponsorsTableAdapter.Fill(this.db14Project20DataSet3.TeamSponsors);
            // TODO: This line of code loads data into the 'db14Project20DataSet2.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.db14Project20DataSet2.Players);
            // TODO: This line of code loads data into the 'db14Project20DataSet1.Sponsors' table. You can move, or remove it, as needed.
            this.sponsorsTableAdapter.Fill(this.db14Project20DataSet1.Sponsors);
            // TODO: This line of code loads data into the 'db14Project20DataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.db14Project20DataSet.Teams);

        }
    }
}
