using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using freightWebApp.Data;
using freightWebApp.Models;

namespace freightWebApp.PagesFreight
{
    public class IndexModel : PageModel
    {
        private readonly freightWebApp.Data.freightWebAppContext _context;

        public IndexModel(freightWebApp.Data.freightWebAppContext context)
        {
            _context = context;
        }

        public IList<Freight> Freight { get;set; }

        public async Task OnGetAsync()
        {
            Freight = await _context.Freight.ToListAsync();
        }
    }
}
