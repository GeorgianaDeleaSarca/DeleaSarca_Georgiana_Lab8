﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeleaSarca_Georgiana_Lab8.Data;
using DeleaSarca_Georgiana_Lab8.Models;

namespace DeleaSarca_Georgiana_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly DeleaSarca_Georgiana_Lab8.Data.DeleaSarca_Georgiana_Lab8Context _context;

        public DetailsModel(DeleaSarca_Georgiana_Lab8.Data.DeleaSarca_Georgiana_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Publisher)
                .Include(b => b.BookCategories)
                .ThenInclude(b => b.Category)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

