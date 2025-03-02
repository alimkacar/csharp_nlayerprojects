using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstarct
{
    public interface IProductService: IGenericService<Product>
    {
        List<Object> TGetProductsWithCategory();

    }
}
