using Microsoft.AspNetCore.Http;
using Project.Core;
using Project.Core.Domain.Users;
using Project.Services.Users;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Project.Web.Framework
{
    public class WorkContext : IWorkContext
    {
        #region Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;

        private User _cachedUser;

        #endregion

        #region Constructor

        public WorkContext(IHttpContextAccessor httpContextAccessor,
            IUserService userService)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        #endregion

        #region Utilities

        protected ClaimsIdentity GetAuthenticationUserIdentity()
        {
            if (_httpContextAccessor.HttpContext != null
                  && _httpContextAccessor.HttpContext.User != null
                  && _httpContextAccessor.HttpContext.User.Identity != null
                  && _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated
                  && _httpContextAccessor.HttpContext.User.Identity is ClaimsIdentity claimsIdentity)
            {
                return claimsIdentity;
            }
            return null;
        }

        protected User GetUserInfo(string mobileNumber)
        {
            if (string.IsNullOrEmpty(mobileNumber))
                return null;

            _cachedUser = _userService.GetUserInfoByMobileNumber(mobileNumber);
            return _cachedUser;
        }

        #endregion

        #region Methods

        public User User
        {
            get
            {
                if (_cachedUser != null)
                    return _cachedUser;

                var identity = GetAuthenticationUserIdentity();
                if (identity != null)
                {
                    var mobileNumberClaim = identity.FindFirst(identity => identity.Type == ClaimTypes.MobilePhone);
                    if (mobileNumberClaim != null)
                    {
                        GetUserInfo(mobileNumberClaim.Value);
                    }
                }
                return _cachedUser;
            }
        }

        public IEnumerable<string> Roles
        {
            get
            {
                var identity = GetAuthenticationUserIdentity();
                if (identity != null)
                {
                    var roles = from role in identity.Claims
                                where role.Type == ClaimTypes.Role
                                select role.Value;
                    return roles;
                }
                return null;
            }
        }

        #endregion
    }
}
