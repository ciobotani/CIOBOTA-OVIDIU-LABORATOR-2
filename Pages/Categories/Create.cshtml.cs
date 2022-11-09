﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CIOBOTA_OVIDIU_LABORATOR_2.Data;
using CIOBOTA_OVIDIU_LABORATOR_2.Models;

namespace CIOBOTA_OVIDIU_LABORATOR_2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly CIOBOTA_OVIDIU_LABORATOR_2.Data.CIOBOTA_OVIDIU_LABORATOR_2Context _context;

        public CreateModel(CIOBOTA_OVIDIU_LABORATOR_2.Data.CIOBOTA_OVIDIU_LABORATOR_2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}