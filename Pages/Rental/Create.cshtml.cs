using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesRenterprise.Data;
using RazorPagesRenterprise.Models;

namespace RazorPagesRenterprise.Pages_Rental
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesRenterprise.Data.RazorPagesRenterpriseContext _context;

        public CreateModel(RazorPagesRenterprise.Data.RazorPagesRenterpriseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rental Rental { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rental.Add(Rental);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
