using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.DTO
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }     
    }
}