using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class HeadAdmin
    {
        [Key]
        public int HeadAdminId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int ContentsAdminID { get; set; }
        public int DiagnosticsAdminID { get; set; }
        public int AccountsAdminID { get; set; }
        public int StatsID { get; set; }


    }
}
