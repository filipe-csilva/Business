using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;

namespace Business.Repository
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(SystemContext dbContext) : base(dbContext)
        {
        }
    }
}
