using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses;
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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoriesController(
            ICategoryRepository categoryRepository,
            IMapper mapper
        )
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryRepository.GetCategories(includeMeals: false);

            var categoryResources =
                _mapper.Map<IEnumerable<Category>, IEnumerable<GetCategoryResponseResource>>(categories);

            return Ok(categoryResources);
        }

        [HttpGet("withMeals")]
        public async Task<IActionResult> GetCategoriesWithMeals()
        {
            var categories = await _categoryRepository.GetCategories();

            var categoryResources =
                _mapper.Map<IEnumerable<Category>, IEnumerable<GetCategoryWithMealsResponseResource>>(categories);

            return Ok(categoryResources);
        }
    }
}
