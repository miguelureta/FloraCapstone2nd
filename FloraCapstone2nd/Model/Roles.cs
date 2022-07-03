using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Roles
    {
        [Key]
        public int RolesId { get; set; }
        public string? Role { get; set; }
    }
}
