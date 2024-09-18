using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Data;
using RazorPagesRenterprise.Models;

namespace RazorPagesRenterprise.Pages_Rental
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesRenterprise.Data.RazorPagesRenterpriseContext _context;

        public IndexModel(RazorPagesRenterprise.Data.RazorPagesRenterpriseContext context)
        {
            _context = context;
        }

        public IList<Rental> Rental { get;set; } = default!;

        //binds the value user inputs to the same name property
        [BindProperty(SupportsGet = true)]
        public string? SearchString {get; set;}

        public async Task OnGetAsync()
        {
            Rental = await _context.Rental.ToListAsync();
            
            var rentals = from r in _context.Rental
                            select r;
            if(!string.IsNullOrEmpty(SearchString)) 
            {
                rentals = rentals.Where(r =>
                 (r.Customer != null && r.Customer.ToLower().Contains(SearchString.ToLower())) ||
                 (r.Reg != null && r.Reg.ToLower().Contains(SearchString.ToLower()))); 
            }
            Rental = await rentals.ToListAsync();
        }
    }
}
