namespace ForumMotor.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public string ForumUserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ForumUser ForumUser { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
