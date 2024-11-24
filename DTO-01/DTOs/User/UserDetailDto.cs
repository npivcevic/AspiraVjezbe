using System.ComponentModel.DataAnnotations;

namespace DTO_01.DTOs.User
{
    public class UserDetailDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }
    }
}
