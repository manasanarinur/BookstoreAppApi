using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.API.Models.User
{
    public class UserDto:LoginUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Role { get; set; }
    }
}