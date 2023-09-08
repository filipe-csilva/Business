using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;

namespace Business.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SystemContext dbContext) : base(dbContext)
        {
        }
    }
}
