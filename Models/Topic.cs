namespace ForumMotor.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public virtual string ForumUserId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ForumUser User { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
