using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.ViewModel
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Username = "";
            Password = "";
            cPassword = "";
            Email = "";
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
    }
}
