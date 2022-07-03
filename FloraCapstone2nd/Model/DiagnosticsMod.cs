using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class DiagnosticsMod
    {
        [Key]
        public int DiagnosticsModId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? ReportedUsers { get; set; }
        public int PlantDiseaseID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeactivated { get; set; }

    }
}
