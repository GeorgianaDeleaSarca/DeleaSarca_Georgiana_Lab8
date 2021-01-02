using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DeleaSarca_Georgiana_Lab8.Models;

namespace DeleaSarca_Georgiana_Lab8.Data
{
    public class DeleaSarca_Georgiana_Lab8Context : DbContext
    {
        public DeleaSarca_Georgiana_Lab8Context (DbContextOptions<DeleaSarca_Georgiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<DeleaSarca_Georgiana_Lab8.Models.Book> Book { get; set; }

        public DbSet<DeleaSarca_Georgiana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<DeleaSarca_Georgiana_Lab8.Models.Category> Category { get; set; }
    }
}
