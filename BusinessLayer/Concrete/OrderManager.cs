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
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetbyId(int id)
        {
            return _orderDal.GetbyId(id);
        }

        public void Insert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void Update(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
