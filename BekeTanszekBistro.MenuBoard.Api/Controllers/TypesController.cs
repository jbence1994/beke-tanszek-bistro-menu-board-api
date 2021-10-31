using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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
    public class TypesController : ControllerBase
    {
        private readonly ITypeRepository _typeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TypesController(
            ITypeRepository typeRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _typeRepository = typeRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
            var types = await _typeRepository.GetTypes(includeMeals: false);

            var typeResources =
                _mapper.Map<IEnumerable<Type>, IEnumerable<GetTypeResponseResource>>(types);

            return Ok(typeResources);
        }

        [HttpGet("withMeals")]
        public async Task<IActionResult> GetTypesWithMeals()
        {
            var types = await _typeRepository.GetTypes();

            var typeResources =
                _mapper.Map<IEnumerable<Type>, IEnumerable<GetTypeWithMealsResponseResource>>(types);

            return Ok(typeResources);
        }
    }
}
