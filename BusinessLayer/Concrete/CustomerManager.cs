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
    public class CustomerManager : ICustomerService
    {

        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetbyId(int id)
        {
            return _customerDal.GetbyId(id);
        }

        public void Insert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
