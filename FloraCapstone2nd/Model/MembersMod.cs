using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class MembersMod
    {
        [Key]
        public int MembersModId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int MemberID { get; set; }

    }
}
