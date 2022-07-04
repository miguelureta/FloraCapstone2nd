using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.ViewModel
{
    public class RegisterViewModelAdmin
    {
        public RegisterViewModelAdmin()
        {
            Username = "";
            Password = "";
            cPassword = "";
            Email = "";
            Role = "";
            Section = "";
        }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string cPassword { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Section { get; set; }
    }
}
