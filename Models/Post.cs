namespace ForumMotor.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ForumUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int TopicId { get; set; }
        public int PostReplies { get; set; }

        public virtual ForumUser User { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual Post Reply { get; set; }
    }
}
