using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Alarms
    {
        [Key]
        public int AlarmId { get; set; }
        public string? AlarmName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
