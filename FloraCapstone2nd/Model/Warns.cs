using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Warns
    {
        [Key]
        public int WarnId { get; set; }
        public string? WarnDesc { get; set; }
        public int WarnCount { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
