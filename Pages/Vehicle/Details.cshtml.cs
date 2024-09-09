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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesRenterprise.Data.RazorPagesRenterpriseContext _context;

        public DetailsModel(RazorPagesRenterprise.Data.RazorPagesRenterpriseContext context)
        {
            _context = context;
        }

        public Vehicle Vehicle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            else
            {
                Vehicle = vehicle;
            }
            return Page();
        }
    }
}
