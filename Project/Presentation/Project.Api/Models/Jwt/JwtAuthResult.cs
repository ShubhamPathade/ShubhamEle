using System.Text.Json.Serialization;

namespace Project.Api.Models.Jwt
{
    public class JwtAuthResult
    {
        #region Properties

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        #endregion
    }
}
