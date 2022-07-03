using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class ForumsMod
    {
        [Key]
        public int ForumsModId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int ForumID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeactivated { get; set; }

    }
}
