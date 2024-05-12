using Microsoft.IdentityModel.Tokens;
using Project.Api.Models.Jwt;
using Project.Core.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Project.Api.Infrastructure.Services
{
    public class JwtAuthManager : IJwtAuthManager
    {
        #region Fields

        private readonly JwtTokenConfig _jwtTokenConfig;

        #endregion

        #region Constructor

        public JwtAuthManager(JwtTokenConfig jwtTokenConfig)
        {
            _jwtTokenConfig = jwtTokenConfig;
        }

        #endregion

        #region Properties

        protected byte[] SecretInBytes
        {
            get => Encoding.ASCII.GetBytes(_jwtTokenConfig.Secret);
        }

        #endregion

        #region Methods

        public (ClaimsPrincipal, JwtSecurityToken) DecodeJwtToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new SecurityTokenException("Invalid token");
            }

            var principal = new JwtSecurityTokenHandler()
                .ValidateToken(token,
                    new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = _jwtTokenConfig.Issuer,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(SecretInBytes),
                        ValidAudience = _jwtTokenConfig.Audience,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.FromMinutes(1)
                    },
                    out var validatedToken);
            return (principal, validatedToken as JwtSecurityToken);
        }

        public JwtAuthResult GenerateTokens(Claim[] claims, DateTime now)
        {
            var shouldAddAudienceClaim = string.IsNullOrWhiteSpace(claims?.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Aud)?.Value);
            var jwtToken = new JwtSecurityToken(
                _jwtTokenConfig.Issuer,
                shouldAddAudienceClaim ? _jwtTokenConfig.Audience : string.Empty,
                claims,
                expires: now.AddDays(_jwtTokenConfig.AccessTokenExpirationInMonths),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(SecretInBytes), SecurityAlgorithms.HmacSha256Signature));
            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            var jwtAuthResult = new JwtAuthResult()
            {
                AccessToken = accessToken
            };

            return jwtAuthResult;
        }

        #endregion
    }
}
