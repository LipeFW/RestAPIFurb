using System.ComponentModel.DataAnnotations;

namespace RestAPIFurb.Models.Dto.Login
{
    public class LoginRequestDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
