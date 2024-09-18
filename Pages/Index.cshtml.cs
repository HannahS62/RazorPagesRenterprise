using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Models;
using RazorPagesRenterprise.Pages_Vehicle;
using System.Threading.Tasks;


namespace RazorPagesRenterprise.Pages;

public class IndexModel : PageModel
{

        private readonly RazorPagesRenterprise.Data.RazorPagesRenterpriseContext _context;

        public IndexModel(RazorPagesRenterprise.Data.RazorPagesRenterpriseContext context)
        {
            _context = context;
        }

        public IList<RazorPagesRenterprise.Models.Rental> Rental { get;set; } = default!;
        public IList<RazorPagesRenterprise.Models.Workshop> Workshop { get;set; } = default!;


        public async Task OnGetAsync()
        {
            Rental = await _context.Rental.ToListAsync();
            Workshop = await _context.Workshop.ToListAsync();
        }
}   





