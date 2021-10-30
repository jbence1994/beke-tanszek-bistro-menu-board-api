using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BekeTanszekBistro.MenuBoard.Api.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]/")]
    public class TypesController : ControllerBase
    {
        private readonly ITypeRepository _typeRepository;
        private readonly IMapper _mapper;

        public TypesController(
            ITypeRepository typeRepository,
            IMapper mapper
        )
        {
            _typeRepository = typeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
            var types = await _typeRepository.GetTypes();

            var typeResources =
                _mapper.Map<IEnumerable<Type>, IEnumerable<GetTypeResponseResource>>(types);

            return Ok(typeResources);
        }
    }
}
