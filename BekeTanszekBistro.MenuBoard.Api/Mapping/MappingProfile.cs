﻿using AutoMapper;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Models to API resources

            CreateMap<Type, GetTypeResponseResource>();

            // API resources to models

        }
    }
}
