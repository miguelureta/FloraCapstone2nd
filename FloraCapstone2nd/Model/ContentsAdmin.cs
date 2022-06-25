namespace FloraCapstone2nd.Model
{
    public class ContentsAdmin
    {
        public int ContentsAdminID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int StatsID { get; set; }
        public int AdsID { get; set; }
        public int ForumsModID { get; set; }
        public int HowTosModID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateDeactivated { get; set; }

    }
}
