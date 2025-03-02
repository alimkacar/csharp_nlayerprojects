using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstarct;
using DataAccessLayer.Context;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        KampContext context = new KampContext();
        private readonly DbSet<T> _object;


        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedentity = context.Entry(entity);
            deletedentity.State= EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetbyId(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedentity = context.Entry(entity);
            addedentity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedentity = context.Entry(entity);
            updatedentity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
