using System.Collections.Generic;
using System.Threading.Tasks;
using  BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Repositories
{
    public interface ITypeRepository
    {
        Task<IEnumerable<Type>> GetTypes();
    }
}
