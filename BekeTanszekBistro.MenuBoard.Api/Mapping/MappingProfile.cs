﻿using AutoMapper;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Requests;
using BekeTanszekBistro.MenuBoard.Api.Controllers.Resources.Responses;
using BekeTanszekBistro.MenuBoard.Api.Core.Models;

namespace BekeTanszekBistro.MenuBoard.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Models to API resources

            CreateMap<Meal, GetMealResponseResource>();
            CreateMap<Meal, GetMealWithTypeResponseResource>();
            CreateMap<Type, GetTypeResponseResource>();
            CreateMap<Type, GetTypeWithMealsResponseResource>();

            // API resources to models

            CreateMap<CreateMealRequestResource, Meal>();
        }
    }
}
