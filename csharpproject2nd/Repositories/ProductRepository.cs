    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharpproject2nd.Dtos;

namespace csharpproject2nd.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProductAsync(CreateProductDto createproductdto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetbyProductIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(UpdateProductDto updateproductdto)
        {
            throw new NotImplementedException();
        }
    }
}
