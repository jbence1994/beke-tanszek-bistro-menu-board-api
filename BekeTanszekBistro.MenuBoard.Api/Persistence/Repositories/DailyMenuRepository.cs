using System.Collections.Generic;
using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence.Repositories
{
    public class DailyMenuRepository : IDailyMenuRepository
    {
        private readonly ApplicationDbContext _context;

        public DailyMenuRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DailyMenu>> GetDailyMenus()
        {
            return await _context.DailyMenus
                .Include(m => m.Meal)
                .ThenInclude(m => m.Type)
                .ToListAsync();
        }

        public async Task<DailyMenu> GetDailyMenu(int id)
        {
            return await _context.DailyMenus
                .Include(m => m.Meal)
                .ThenInclude(m => m.Type)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task Add(DailyMenu dailyMenu)
        {
            await _context.DailyMenus.AddAsync(dailyMenu);
        }

        public void Remove(DailyMenu dailyMenu)
        {
            _context.DailyMenus.Remove(dailyMenu);
        }

        public void RemoveAll()
        {
            _context.DailyMenus.RemoveRange(_context.DailyMenus);
        }
    }
}
