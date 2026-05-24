using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_JORGE.Data;
using WebApplication_JORGE.Models;

namespace WebApplication__JORGE.Pages.Developers
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public DeleteModel(WebApplication_JORGE.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmpleadoDeveloper EmpleadoDeveloper { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleadodeveloper = await _context.EmpleadosDevelopers.FirstOrDefaultAsync(m => m.Id == id);

            if (empleadodeveloper is not null)
            {
                EmpleadoDeveloper = empleadodeveloper;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleadodeveloper = await _context.EmpleadosDevelopers.FindAsync(id);
            if (empleadodeveloper != null)
            {
                EmpleadoDeveloper = empleadodeveloper;
                _context.EmpleadosDevelopers.Remove(EmpleadoDeveloper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
