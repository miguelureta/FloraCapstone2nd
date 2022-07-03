using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Statistics
    {
        [Key]
        public int StatsId { get; set; }
        public int UserTotalCount { get; set; }
        public int BannedUsersCount { get; set; }
        public int UserID { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
