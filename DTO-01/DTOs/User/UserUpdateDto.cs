using System.ComponentModel.DataAnnotations;

namespace DTO_01.DTOs.User
{
    public class UserUpdateDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Phone]
        public string? PhoneNumber { get; set; }
    }
}
