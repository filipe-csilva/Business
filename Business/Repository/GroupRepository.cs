using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;

namespace Business.Repository
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(SystemContext dbContext) : base(dbContext)
        {
        }
    }
}
