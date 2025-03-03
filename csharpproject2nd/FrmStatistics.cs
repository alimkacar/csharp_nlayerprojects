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
using Dapper;

namespace csharpproject2nd.Repositories
{
    public partial class FrmStatistics: Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-ASRSF7U\\SQLEXPRESS;Initial Catalog=csharpdapper;integrated security=true;");
        private async void FrmStatistics_Load(object sender, EventArgs e)
        {
            string query = "select count (*) from TblProduct";
            var producttotalcount = await sqlConnection.QueryFirstOrDefaultAsync<int>(query);
            lbltotalProductCount.Text= producttotalcount.ToString();

            string query2 = "select ProductName from TblProduct where ProductPrice=(Select MAX(ProductPrice) from TblProduct)";
            var mostexpensiveproduct = await sqlConnection.QueryFirstOrDefaultAsync<string>(query2);
            lblmostexpensive.Text = mostexpensiveproduct.ToString();

            string query3 = "select count(distinct(ProductCategory)) from TblProduct ";
            var categorycount = await sqlConnection.QueryFirstOrDefaultAsync<int>(query3);
            lblCategoryCount.Text= categorycount.ToString();
        }
    }
}
