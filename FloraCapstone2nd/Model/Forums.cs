namespace FloraCapstone2nd.Model
{
    public class Forums
    {
        public int ForumID { get; set; }
        public string ForumTitle { get; set; }
        public string Description { get; set; }
        public int ReplyID { get; set; }
        public int UserID { get; set; }
        public int ForumViewCount { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
