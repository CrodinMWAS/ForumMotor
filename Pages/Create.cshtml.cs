﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForumMotor.Data;
using ForumMotor.Models;
using Microsoft.AspNetCore.Authorization;

namespace ForumMotor.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ForumMotor.Data.ApplicationDbContext _context;

        public CreateModel(ForumMotor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ForumUserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            var currentUserId = User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            Category.ForumUserId = currentUserId;

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
