using Project04_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project04_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project04_EntityFrameworkCodeFirstMovie
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }

        MovieContext context = new MovieContext();

        void CategoryList()
        {
            var values = context.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtName.Text;
            movie.Description = txtDetails.Text;
            movie.CreatedDate = DateTime.Parse (mskDate.Text);
            movie.CategoryId = int. Parse (cmbCategory.SelectedValue.ToString());
            movie.Duration = int.Parse (txtDuration.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }
    }
}
