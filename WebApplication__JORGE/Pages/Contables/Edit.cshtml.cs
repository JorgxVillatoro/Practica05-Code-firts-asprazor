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

namespace WebApplication__JORGE.Pages.Contables
{
    public class EditModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public EditModel(WebApplication_JORGE.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmpleadosContables EmpleadosContables { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleadoscontables =  await _context.EmpleadosContables.FirstOrDefaultAsync(m => m.Id == id);
            if (empleadoscontables == null)
            {
                return NotFound();
            }
            EmpleadosContables = empleadoscontables;
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

            _context.Attach(EmpleadosContables).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadosContablesExists(EmpleadosContables.Id))
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

        private bool EmpleadosContablesExists(int id)
        {
            return _context.EmpleadosContables.Any(e => e.Id == id);
        }
    }
}
