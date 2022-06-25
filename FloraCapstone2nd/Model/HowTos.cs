﻿namespace FloraCapstone2nd.Model
{
    public class HowTos
    {
        public int HowTosID { get; set; }
        public int UserID { get; set; }
        public string HowTosTitle { get; set; }
        public string Description { get; set; }
        public int PlantID { get; set; }
        public int HowTosViewCount { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public DateTime DateAdded { get; set; }

    }
}