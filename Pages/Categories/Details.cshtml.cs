using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIOBOTA_OVIDIU_LABORATOR_2.Data;
using CIOBOTA_OVIDIU_LABORATOR_2.Models;

namespace CIOBOTA_OVIDIU_LABORATOR_2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly CIOBOTA_OVIDIU_LABORATOR_2.Data.CIOBOTA_OVIDIU_LABORATOR_2Context _context;

        public DetailsModel(CIOBOTA_OVIDIU_LABORATOR_2.Data.CIOBOTA_OVIDIU_LABORATOR_2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
