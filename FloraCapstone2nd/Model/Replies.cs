using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Replies
    {
        [Key]
        public int ReplyId { get; set; }
        public int UserID { get; set; }
        public string? ReplyText { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
