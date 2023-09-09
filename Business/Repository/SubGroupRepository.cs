using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;

namespace Business.Repository
{
    public class SubGroupRepository : GenericRepository<SubGroup>, ISubGroupRepository
    {
        public SubGroupRepository(SystemContext dbContext) : base(dbContext)
        {
        }
    }
}
