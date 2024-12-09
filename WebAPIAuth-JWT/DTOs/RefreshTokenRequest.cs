using System.ComponentModel.DataAnnotations;

namespace WebAPIAuth_JWT.DTOs
{
    public class RefreshTokenRequest
    {
        [Required]
        public required string RefreshToken { get; set; }
    }
}
