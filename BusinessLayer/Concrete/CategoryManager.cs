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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetbyId(int id)
        {
            return _categoryDal.GetbyId(id);
        }

        public void Insert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
