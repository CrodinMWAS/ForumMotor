using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForumMotor.Data;
using ForumMotor.Models;

namespace ForumMotor.Pages.TopicPages
{
    public class IndexModel : PageModel
    {
        private readonly ForumMotor.Data.ApplicationDbContext _context;

        public IndexModel(ForumMotor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Topic> Topic { get;set; } = default!;

        public Category Category { get; set; } = default!;

        public async Task OnGetAsync(int? categoryId)
        {

            Category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);

            Topic = await _context.Topics
                .Where(t => t.CategoryId == categoryId)
                .Include(t => t.Category)
                .Include(t => t.ForumUser).ToListAsync();
        }
    }
}
