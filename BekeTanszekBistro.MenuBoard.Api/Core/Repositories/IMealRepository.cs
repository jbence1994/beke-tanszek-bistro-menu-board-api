using System.Collections.Generic;
using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Repositories
{
    public interface IMealRepository
    {
        Task<IEnumerable<Meal>> GetMeals();
        Task<Meal> GetMeal(int id);
        Task Add(Meal meal);
    }
}
