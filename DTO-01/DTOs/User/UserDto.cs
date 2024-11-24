using System.ComponentModel.DataAnnotations;

namespace DTO_01.DTOs.User
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

    }
}
