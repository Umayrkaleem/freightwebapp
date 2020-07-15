using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using freightWebApp.Data;
using freightWebApp.Models;

namespace freightWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly freightWebApp.Data.freightWebAppContext _context;

        public CreateModel(freightWebApp.Data.freightWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Freight Freight { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Freight.Add(Freight);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
