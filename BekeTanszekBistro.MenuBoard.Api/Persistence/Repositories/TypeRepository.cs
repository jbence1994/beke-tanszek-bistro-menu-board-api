using System.Collections.Generic;
using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly ApplicationDbContext _context;

        public TypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Type>> GetTypes(bool includeMeals = true)
        {
            if (includeMeals)
            {
                return await _context.Types
                    .Include(t => t.Meals)
                    .ToListAsync();
            }

            return await _context.Types.ToListAsync();
        }

        public async Task<Type> GetType(int id)
        {
            return await _context.Types.SingleOrDefaultAsync(t => t.Id == id);
        }

        public async Task Add(Type type)
        {
            await _context.Types.AddAsync(type);
        }
    }
}
