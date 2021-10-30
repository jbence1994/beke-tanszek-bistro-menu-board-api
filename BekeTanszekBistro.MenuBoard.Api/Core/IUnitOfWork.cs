using System.Threading.Tasks;

namespace BekeTanszekBistro.MenuBoard.Api.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
