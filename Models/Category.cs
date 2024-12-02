namespace ForumMotor.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ForumUserId { get; set; }
        public virtual ForumUser ForumUser { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
    }
}
