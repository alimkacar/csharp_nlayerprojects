using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstarct;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {


        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetbyId(int id)
        {
            return _productDal.GetbyId(id);
        }

        public void Insert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public List<Object> TGetProductsWithCategory()
        {
            return _productDal.GetProductsWithCategory();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
