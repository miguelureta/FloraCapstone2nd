using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Bans
    {
        [Key]
        public int BanId { get; set; }
        public string? BanDesc { get; set; }
        public int BanCount { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
