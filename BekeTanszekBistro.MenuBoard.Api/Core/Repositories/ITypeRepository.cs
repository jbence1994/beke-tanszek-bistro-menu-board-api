using System.Collections.Generic;
using System.Threading.Tasks;
using  BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Repositories
{
    public interface ITypeRepository
    {
        Task<IEnumerable<Type>> GetTypes(bool includeMeals = true);
        Task<Type> GetType(int id);
        Task Add(Type type);
    }
}
