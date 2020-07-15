using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using freightWebApp.Data;
using freightWebApp.Models;

namespace freightWebApp.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly freightWebApp.Data.freightWebAppContext _context;

        public DeleteModel(freightWebApp.Data.freightWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Freight Freight { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Freight = await _context.Freight.FirstOrDefaultAsync(m => m.ID == id);

            if (Freight == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Freight = await _context.Freight.FindAsync(id);

            if (Freight != null)
            {
                _context.Freight.Remove(Freight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
