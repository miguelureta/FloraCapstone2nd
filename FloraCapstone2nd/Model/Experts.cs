﻿using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Experts
    {
        [Key]
        public int ExpertId { get; set; }
        public string? UploadedProof { get; set; }
        public int RegulatoryID { get; set; }
        public int AlarmID { get; set; }
        public int HowTosID { get; set; }

    }
}
