using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.ViewModel
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            Username = "";
            Password = "";
            ReturnUrl = "";
        }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
