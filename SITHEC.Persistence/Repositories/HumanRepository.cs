using SITHEC.Application.Contracts.Persistence;
using SITHEC.Domain;

namespace SITHEC.Persistence.Repositories
{
    public class HumanRepository : GenericRepository<Human>, IHumanRepository
    {
        private readonly ApplicationDbContext _context;

        public HumanRepository(ApplicationDbContext context)
            :base(context)
        {
            _context = context;
        }
    }
}
