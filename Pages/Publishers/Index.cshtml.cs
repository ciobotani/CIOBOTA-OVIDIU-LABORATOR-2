using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CIOBOTA_OVIDIU_LABORATOR_2.Data;
using CIOBOTA_OVIDIU_LABORATOR_2.Models;

namespace CIOBOTA_OVIDIU_LABORATOR_2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly CIOBOTA_OVIDIU_LABORATOR_2.Data.CIOBOTA_OVIDIU_LABORATOR_2Context _context;

        public IndexModel(CIOBOTA_OVIDIU_LABORATOR_2.Data.CIOBOTA_OVIDIU_LABORATOR_2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
