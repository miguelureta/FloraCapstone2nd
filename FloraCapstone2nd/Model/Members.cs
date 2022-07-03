using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Members
    {
        [Key]
        public int MemberId { get; set; }
        public int RegulatoryID { get; set; }
        public int AlarmID { get; set; }
        public int BookmarkID { get; set; }
        public int SubscriptionID { get; set; }

    }
}
