using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using freightWebApp.Data;
using freightWebApp.Models;

namespace freightWebApp.PagesFreight
{
    public class EditModel : PageModel
    {
        private readonly freightWebApp.Data.freightWebAppContext _context;

        public EditModel(freightWebApp.Data.freightWebAppContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Freight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FreightExists(Freight.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FreightExists(int id)
        {
            return _context.Freight.Any(e => e.ID == id);
        }
    }
}
