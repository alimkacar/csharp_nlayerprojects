using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstarct;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        List<Object> IProductDal.GetProductsWithCategory()
        {
            var context = new KampContext();
            var values = context.Products
                .Select(x => new 
                {
                    ProductId=x.ProductId,
                    ProductName = x.ProductName,
                    ProductDescription =x.ProductDescription,
                    ProductPrice =x.ProductPrice,
                    ProductStock=x.ProductStock,
                    
                    CategoryName =x.Category.CategoryName
                }).ToList();
            return values.Cast<Object>().ToList();
        }
    }
}
