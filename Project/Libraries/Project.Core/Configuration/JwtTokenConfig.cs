using System.Text.Json.Serialization;

namespace Project.Core.Configuration
{
    public class JwtTokenConfig
    {
        #region Properties

        [JsonPropertyName("secret")]
        public string Secret { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("audience")]
        public string Audience { get; set; }

        [JsonPropertyName("accessTokenExpirationInMonths")]
        public int AccessTokenExpirationInMonths { get; set; }

        [JsonPropertyName("refreshTokenExpiration")]
        public int RefreshTokenExpiration { get; set; }

        #endregion
    }
}
