using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Abstarct;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace PresentationLayera
{
    public partial class Form1 : Form
    {
        private readonly ICategoryService _categoryService;

        public Form1()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            var categoryvalues = _categoryService.GetAll();
            dataGridView1.DataSource = categoryvalues;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.Insert(category);
            MessageBox.Show("Kategori Başarıyla eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedvalue=_categoryService.GetbyId(id);
            _categoryService.Delete(deletedvalue);
            MessageBox.Show("Kategori Başarıyla Silindi");
        }

        private void btnGetbyId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var getbyidvalue = _categoryService.GetbyId(id);
            dataGridView1.DataSource = getbyidvalue;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            int updatedid= int.Parse(txtCategoryId.Text);
            var updatedvalue = _categoryService.GetbyId(updatedid);
            updatedvalue.CategoryName = txtCategoryName.Text;
            updatedvalue.CategoryStatus = true;
            _categoryService.Update(updatedvalue);
        }
    }
}
