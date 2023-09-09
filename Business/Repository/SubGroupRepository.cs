using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public class SubGroupRepository : GenericRepository<SubGroup>, ISubGroupRepository
    {
        public SubGroupRepository(SystemContext dbContext) : base(dbContext)
        {
        }

        override
        public async Task<ICollection<SubGroup>> GetAll()
        {
            return await _dbContext.Set<SubGroup>().Include(s => s.Group).ToListAsync();
        }
    }
}
