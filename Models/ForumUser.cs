using Microsoft.AspNetCore.Identity;

namespace ForumMotor.Models
{
    public class ForumUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LinganGuli {  get; set; }
        public int Guli {  get; set; }
    }
}
