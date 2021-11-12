using System.Collections.Generic;
using System.Threading.Tasks;
using  BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories(bool includeMeals = true);
    }
}
