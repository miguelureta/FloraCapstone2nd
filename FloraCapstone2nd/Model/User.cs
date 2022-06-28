using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class User
    {
        [Key]
        public int? UserId { get; set; }
        public string? Username { get; set; }
        public char Password { get; set; }
        public string? Email { get; set; }
        public int SubscriptionID { get; set; }
        public int RoleID { get; set; }
        public DateTime DateAdded  { get; set; }

    }
}
