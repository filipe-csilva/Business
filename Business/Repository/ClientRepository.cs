using Business.Data;
using Business.Models;
using Business.Repository.Interfaces;

namespace Business.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(SystemContext dbContext) : base(dbContext)
        {
        }
    }
}
