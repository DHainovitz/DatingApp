using System.ComponentModel.DataAnnotations;

namespace DatingWebAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength = 4,ErrorMessage="password btwn 4 & 8 chars")]
        public string Password { get; set; }
    }
}