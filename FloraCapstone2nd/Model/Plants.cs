﻿using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Plants
    {
        [Key]
        public int PlantId { get; set; }
        public string? PlantName { get; set; }
        public string? ScientificName { get; set; }
        public string? PlantType { get; set; }
        public string? PlantDesc { get; set; }
        public int PlantDiseaseID { get; set; }

    }
}
