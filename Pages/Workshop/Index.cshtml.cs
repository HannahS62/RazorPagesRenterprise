using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Data;
using RazorPagesRenterprise.Models;

namespace RazorPagesRenterprise.Pages_Workshop
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesRenterprise.Data.RazorPagesRenterpriseContext _context;

        public IndexModel(RazorPagesRenterprise.Data.RazorPagesRenterpriseContext context)
        {
            _context = context;
        }

        public IList<Workshop> Workshop { get;set; } = default!;

        //binds the value user inputs to the same name property
        [BindProperty(SupportsGet = true)]
        public string? SearchString {get; set;}

        public async Task OnGetAsync()
        {
            Workshop = await _context.Workshop.ToListAsync();

                        var workshops = from w in _context.Workshop
                            select w;
            if(!string.IsNullOrEmpty(SearchString)) 
            {
                workshops = workshops.Where(w =>w.Reg != null && w.Reg.ToLower().Contains(SearchString.ToLower()));
                
            }
            Workshop = await workshops.ToListAsync();
        }

        }
    }

