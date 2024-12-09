using System.ComponentModel.DataAnnotations;

namespace WebAPIAuth_JWT.DTOs
{
    public class TokenResponse
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }
    }
}
