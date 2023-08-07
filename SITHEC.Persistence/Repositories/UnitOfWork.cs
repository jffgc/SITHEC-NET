using SITHEC.Application.Contracts.Persistence;

namespace SITHEC.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IHumanRepository _humanRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IHumanRepository HumanRepository => _humanRepository ??= new HumanRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
