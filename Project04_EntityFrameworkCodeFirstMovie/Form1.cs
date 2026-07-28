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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MovieContext Context = new MovieContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = Context.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtName.Text;
            Context.Categories.Add(category);
            Context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = Context.Categories.Find(id); 
            value.CategoryName = txtName.Text;
            Context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = Context.Categories.Find(id);
            Context.Categories.Remove(values);
            Context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = Context.Categories.Where(x => x.CategoryName == txtName.Text).ToList();
            dataGridView1.DataSource = values; 
        }
    }
}
