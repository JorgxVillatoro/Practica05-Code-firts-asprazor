using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication_JORGE.Data;
using WebApplication_JORGE.Models;

namespace WebApplication__JORGE.Pages.Developers
{
    public class EditModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public EditModel(WebApplication_JORGE.Data.ApplicationDbContext context)
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

            var empleadodeveloper =  await _context.EmpleadosDevelopers.FirstOrDefaultAsync(m => m.Id == id);
            if (empleadodeveloper == null)
            {
                return NotFound();
            }
            EmpleadoDeveloper = empleadodeveloper;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmpleadoDeveloper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoDeveloperExists(EmpleadoDeveloper.Id))
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

        private bool EmpleadoDeveloperExists(int id)
        {
            return _context.EmpleadosDevelopers.Any(e => e.Id == id);
        }
    }
}
