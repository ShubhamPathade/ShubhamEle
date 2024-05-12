using AutoMapper;
using Project.Api.Models.User;
using Project.Core.Domain.Common;
using Project.Core.Domain.Companies;
using Project.Core.Domain.Customers;
using Project.Core.Domain.Managers;
using Project.Core.Domain.Users;
using Project.Core.Domain.Vendors;
using Project.Core.Infrastructure.Mapper;

namespace Project.Api.Infrastructure.Mapper
{
    public class MapperConfiguration : Profile, IOrderedMapperProfile
    {
        #region Constants

        private const string DATE_FORMATE = "dd MMM yyyy";

        #endregion

        #region Constructor

        public MapperConfiguration()
        {
           
        }

        #endregion


        #region Properties

        public int Order => 0;

        #endregion
    }
}
