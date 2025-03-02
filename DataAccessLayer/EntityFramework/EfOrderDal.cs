using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstarct;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<EfOrderDal>, IOrderDal
    {
        void IGenericDal<Order>.Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        List<Order> IGenericDal<Order>.GetAll()
        {
            throw new NotImplementedException();
        }

        Order IGenericDal<Order>.GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<Order>.Insert(Order entity)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<Order>.Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
