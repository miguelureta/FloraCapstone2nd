namespace FloraCapstone2nd.Model
{
    public class DiagnosticsAdmin
    {
        public int DiagnosticsAdminId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? ReportedUsers { get; set; }
        public int PlantID { get; set; }
        public int PlantDiseaseID { get; set; }
        public int DiagnosticsModID { get; set; }
        public int StatsID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeactivated { get; set; }

    }
}
