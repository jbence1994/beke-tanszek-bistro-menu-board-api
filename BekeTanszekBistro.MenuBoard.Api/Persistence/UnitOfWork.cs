using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
