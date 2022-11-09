using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIOBOTA_OVIDIU_LABORATOR_2.Models;

namespace CIOBOTA_OVIDIU_LABORATOR_2.Data
{
    public class CIOBOTA_OVIDIU_LABORATOR_2Context : DbContext
    {
        public CIOBOTA_OVIDIU_LABORATOR_2Context (DbContextOptions<CIOBOTA_OVIDIU_LABORATOR_2Context> options)
            : base(options)
        {
        }

        public DbSet<CIOBOTA_OVIDIU_LABORATOR_2.Models.Book> Book { get; set; } = default!;

        public DbSet<CIOBOTA_OVIDIU_LABORATOR_2.Models.Publisher> Publisher { get; set; }

        public DbSet<CIOBOTA_OVIDIU_LABORATOR_2.Models.Category> Category { get; set; }
    }
}
