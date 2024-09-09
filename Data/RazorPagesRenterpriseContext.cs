using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Models;

namespace RazorPagesRenterprise.Data
{
    public class RazorPagesRenterpriseContext : DbContext
    {
        public RazorPagesRenterpriseContext (DbContextOptions<RazorPagesRenterpriseContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesRenterprise.Models.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<RazorPagesRenterprise.Models.Rental> Rental { get; set; } = default!;
        public DbSet<RazorPagesRenterprise.Models.Workshop> Workshop { get; set; } = default!;
    }
}
