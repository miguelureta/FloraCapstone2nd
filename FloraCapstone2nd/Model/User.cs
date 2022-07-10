using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    //Made User inherit IdentityUser as Custom role
    public class User : IdentityUser
    { 
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public int SubscriptionID { get; set; }
        public int RoleID { get; set; }
        public DateTime DateAdded  { get; set; }

    }
}
