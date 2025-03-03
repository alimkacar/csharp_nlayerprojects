using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharpproject2nd.Dtos;

namespace csharpproject2nd.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createproductdto);
        Task UpdateProductAsync(UpdateProductDto updateproductdto);
        Task DeleteProductAsync(int id);
        Task GetbyProductIdAsync(int id);
    }
}
