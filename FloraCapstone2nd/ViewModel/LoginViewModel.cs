using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.ViewModel
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            AppUsername = "";
            AppPassword = "";
        }
        [Required]
        public string AppUsername { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string AppPassword { get; set; }
    }
}
