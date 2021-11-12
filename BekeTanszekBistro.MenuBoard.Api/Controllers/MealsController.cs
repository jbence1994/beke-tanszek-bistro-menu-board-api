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
    public class MealsController : ControllerBase
    {
        private readonly IMealRepository _mealRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MealsController(
            IMealRepository mealRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _mealRepository = mealRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMeals()
        {
            var meals = await _mealRepository.GetMeals();

            var mealResources =
                _mapper.Map<IEnumerable<Meal>, IEnumerable<GetMealResponseResource>>(meals);

            return Ok(mealResources);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMeal([FromBody] CreateMealRequestResource createMealResource)
        {
            var meal = _mapper.Map<CreateMealRequestResource, Meal>(createMealResource);

            await _mealRepository.Add(meal);
            await _unitOfWork.CompleteAsync();

            meal = await _mealRepository.GetMeal(meal.Id);

            var mealResource = _mapper.Map<Meal, GetMealWithCategoryResponseResource>(meal);

            return Ok(mealResource);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMeal(int id)
        {
            var meal = await _mealRepository.GetMeal(id);

            _mealRepository.Remove(meal);
            await _unitOfWork.CompleteAsync();

            var mealResource = _mapper.Map<Meal, GetMealWithCategoryResponseResource>(meal);

            return Ok(mealResource);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMeals()
        {
            _mealRepository.RemoveAll();
            await _unitOfWork.CompleteAsync();

            return Ok();
        }
    }
}
