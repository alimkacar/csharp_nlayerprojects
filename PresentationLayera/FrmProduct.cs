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
    public partial class FrmProduct: Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        
        public FrmProduct()
        {
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var productvalues = _productService.GetAll();
            dataGridView1.DataSource = productvalues;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.ProductName = txtProductName.Text;
            newProduct.ProductPrice = int.Parse(txtProductPrice.Text);
            newProduct.ProductStock = int.Parse(txtPrdocutStock.Text);
            newProduct.ProductDescription = txtProductDescription.Text;
            newProduct.CategoryId =(int)cmbProductCategory.SelectedValue;
            _productService.Insert(newProduct);
            MessageBox.Show("Ürün Başarıyla Eklenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int deletedid = int.Parse(txtCategoryId.Text);
            var deletedvalue = _productService.GetbyId(deletedid);
            _productService.Delete(deletedvalue);
            MessageBox.Show("Ürün Başarıyla Silinmiştir");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int updatedid = int.Parse(txtCategoryId.Text);
            var updatedvalue = _productService.GetbyId(updatedid);
            updatedvalue.ProductName = txtProductName.Text;
            updatedvalue.ProductPrice = int.Parse(txtProductPrice.Text);
            updatedvalue.ProductStock = int.Parse(txtProductPrice.Text);
            updatedvalue.ProductDescription = txtProductDescription.Text;
            updatedvalue.CategoryId = (int)cmbProductCategory.SelectedValue;
            _productService.Update(updatedvalue);
            MessageBox.Show("Ürün Başarıyla Güncellenmiştir");
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;

        }

        private void btnGetbyId_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var idvalue = _productService.GetbyId(id);
            dataGridView1.DataSource = idvalue;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = _categoryService.GetAll();
            cmbProductCategory.DataSource = values;
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
        }
    }
}
