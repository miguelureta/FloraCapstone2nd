using System.ComponentModel.DataAnnotations;

namespace FloraCapstone2nd.Model
{
    public class Bookmarks
    {
        [Key]
        public int BookmarkId { get; set; }
        public int HowTosID { get; set; }
        public int ForumID { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
