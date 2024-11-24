using DTO_01.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace DTO_01.DTOs.User
{
    public class UserCreateDto
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        [UniqueEmail]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(6)]
        public string Password { get; set; } = null!;

        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
