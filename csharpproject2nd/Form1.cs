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
using csharpproject2nd.Connection_String;
using csharpproject2nd.Dtos;
using csharpproject2nd.Repositories;
using Dapper;

namespace csharpproject2nd
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ASRSF7U\\SQLEXPRESS;Initial Catalog=csharpdapper;integrated security=true;");

        private async void btnListele_Click(object sender, EventArgs e)
        {
            string query = "select * from TblProduct";
            var values = await sqlConnection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;

        }

        private async Task btnEkle_Click(object sender, EventArgs e)
        {
            string query = "insert into TblProduct values(ProductName,ProductStock,ProdcutPrice,ProductCategory) values (@ProductName,@ProductStock,@ProductPrice,@ProductCategory";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductName", txtProductName.Text);
            parameters.Add("@ProductStock", txtProductStock.Text);
            parameters.Add("@ProductPrice", txtProductPrice.Text);
            parameters.Add("@ProductCategory", txtProductCategory.Text);
            await sqlConnection.ExecuteAsync(query, parameters);
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            string query = "delete from TblProduct where ProductId = @ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductId", txtProductId.Text);
            await sqlConnection.ExecuteAsync(query, parameters);
            MessageBox.Show("Silme İşlemi Başarılı");

        }

        private async Task btnGüncelle_Click(object sender, EventArgs e)
        {
            string query = "update TblProduct set ProductName = @ProductName, ProductStock = @ProductStock, ProductPrice = @ProductPrice, ProductCategory = @ProductCategory where ProductId = @ProductId";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductName", txtProductName.Text);
            parameters.Add("@ProductStock", txtProductStock.Text);
            parameters.Add("@ProductPrice", txtProductPrice.Text);
            parameters.Add("@ProductCategory", txtProductCategory.Text);
            parameters.Add("@ProductId", txtProductId.Text);
            await sqlConnection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();
            this.Hide();
        }
    }
}
