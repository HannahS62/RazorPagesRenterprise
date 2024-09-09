using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Data;
using RazorPagesRenterprise.Models;

namespace RazorPagesRenterprise.Pages_Vehicle
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesRenterprise.Data.RazorPagesRenterpriseContext _context;

        public IndexModel(RazorPagesRenterprise.Data.RazorPagesRenterpriseContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
