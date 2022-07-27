global using System.ComponentModel.DataAnnotations;

namespace Project.Model
{
    public class UserRegisterRequest
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;


    }
}
