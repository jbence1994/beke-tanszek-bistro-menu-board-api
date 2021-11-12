using System.Collections.Generic;
using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence.Repositories
{
    public class MealRepository : IMealRepository
    {
        private readonly ApplicationDbContext _context;

        public MealRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Meal>> GetMeals()
        {
            return await _context.Meals.ToListAsync();
        }

        public async Task<Meal> GetMeal(int id)
        {
            return await _context.Meals
                .Include(meal => meal.Type)
                .SingleOrDefaultAsync(meal => meal.Id == id);
        }

        public async Task Add(Meal meal)
        {
            await _context.Meals.AddAsync(meal);
        }

        public void Remove(Meal meal)
        {
            _context.Meals.Remove(meal);
        }

        public void RemoveAll()
        {
            _context.Meals.RemoveRange(_context.Meals);
        }
    }
}
