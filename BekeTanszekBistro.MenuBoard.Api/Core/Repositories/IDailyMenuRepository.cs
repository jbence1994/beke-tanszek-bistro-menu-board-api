using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Core.Repositories
{
    public interface IDailyMenuRepository
    {
        Task<IEnumerable<DailyMenu>> GetDailyMenus();
        Task<DailyMenu> GetDailyMenu(DateTime date);
        Task Add(DailyMenu dailyMenu);
    }
}
