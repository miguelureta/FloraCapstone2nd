using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class RegulatoryInfo
    {
        [Key]
        public int RegulatoryId { get; set; }
        public int WarnID { get; set; }
        public int BanID { get; set; }

    }
}
