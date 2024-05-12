﻿using AutoMapper;
using Project.Core.Domain.Companies;
using Project.Core.Domain.Customers;
using Project.Core.Domain.Managers;
using Project.Core.Domain.States;
using Project.Core.Domain.Users;
using Project.Core.Domain.Vendors;
using Project.Core.Infrastructure.Mapper;
using Project.Web.Models.States;

namespace Project.Web.Infrastructure.Mapper
{
    public class MapperConfiguration : Profile, IOrderedMapperProfile
    {
        #region Constructor

        public MapperConfiguration()
        {
            StateMap();
		}

        #endregion

        #region Utilities

        protected void StateMap()
        {
            CreateMap<StateModel, State>();
            CreateMap<State, StateModel>();
        }
    
        #endregion

        #region Properties

        public int Order => 0;

        #endregion
    }
}
