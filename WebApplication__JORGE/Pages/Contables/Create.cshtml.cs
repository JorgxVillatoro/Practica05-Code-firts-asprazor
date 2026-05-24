using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication_JORGE.Data;
using WebApplication_JORGE.Models;

namespace WebApplication__JORGE.Pages.Contables
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public CreateModel(WebApplication_JORGE.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmpleadosContables EmpleadosContables { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmpleadosContables.Add(EmpleadosContables);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
