using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class ExpertsMod
    {
        [Key]
        public int ExpertsModId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int ExpertID { get; set; }

    }
}
