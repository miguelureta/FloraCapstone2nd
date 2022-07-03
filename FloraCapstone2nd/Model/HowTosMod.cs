using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class HowTosMod
    {
        [Key]
        public int HowTosModId { get; set; }
        public int UserID { get; set; }
        public int PlantID { get; set; }
        public int HowTosID { get; set; }

    }
}
