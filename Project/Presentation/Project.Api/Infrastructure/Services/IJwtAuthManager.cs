using Project.Api.Models.Jwt;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Project.Api.Infrastructure.Services
{
    public interface IJwtAuthManager
    {
        #region Methods

        (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token);
        JwtAuthResult GenerateTokens(Claim[] claims, DateTime now);

        #endregion
    }
}
