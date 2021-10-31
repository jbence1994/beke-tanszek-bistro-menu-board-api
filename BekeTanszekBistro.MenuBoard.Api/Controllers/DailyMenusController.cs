using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Requests;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses;
using BekeTanszekBistro.MenuBoard.Api.Core;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Core.Repositories;
using BekeTanszekBistro.MenuBoard.Api.Helpers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]/")]
    [EnableCors(Constants.DefaultCorsPolicy)]
    public class DailyMenusController : ControllerBase
    {
        private readonly IDailyMenuRepository _dailyMenuRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DailyMenusController(
            IDailyMenuRepository dailyMenuRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _dailyMenuRepository = dailyMenuRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetDailyMenus()
        {
            var dailyMenus = await _dailyMenuRepository.GetDailyMenus();

            var dailyMenuResources =
                _mapper.Map<IEnumerable<DailyMenu>, IEnumerable<GetDailyMenuResponseResource>>(dailyMenus);

            return Ok(dailyMenuResources);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDailyMenu(
            [FromBody] CreateDailyMenuRequestResource createDailyMenuResource
        )
        {
            var dailyMenu = _mapper.Map<CreateDailyMenuRequestResource, DailyMenu>(createDailyMenuResource);

            await _dailyMenuRepository.Add(dailyMenu);
            await _unitOfWork.CompleteAsync();

            dailyMenu = await _dailyMenuRepository.GetDailyMenu(dailyMenu.Id);

            var dailyMenuResource = _mapper.Map<DailyMenu, GetDailyMenuResponseResource>(dailyMenu);

            return Ok(dailyMenuResource);
        }
    }
}
