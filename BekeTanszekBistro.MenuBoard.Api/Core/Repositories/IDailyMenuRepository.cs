using System.Collections.Generic;
using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Repositories
{
    public interface IDailyMenuRepository
    {
        Task<IEnumerable<DailyMenu>> GetDailyMenus();
        Task<DailyMenu> GetDailyMenu(int id);
        Task Add(DailyMenu dailyMenu);
        void RemoveAll();
    }
}
