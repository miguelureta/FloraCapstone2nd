namespace FloraCapstone2nd.Model
{
    public class PlantDiseases
    {
        public int PlantDiseaseId { get; set; }
        public int PlantID { get; set; }
        public string? PlantDiseaseName { get; set; }
        public string? DiseaseSymptoms { get; set; }
        public string? AffectedPart { get; set; }
        public string? DiseaseDesc { get; set; }
        public string? DiseaseCause { get; set; }
        public string? DiseaseCure { get; set; }
        public float CurePriceAvg { get; set; }
        public string? Media { get; set; }

    }
}
