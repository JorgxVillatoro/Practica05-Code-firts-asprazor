using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_JORGE.Data;
using WebApplication_JORGE.Models;

namespace WebApplication__JORGE.Pages.Contables
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public DetailsModel(WebApplication_JORGE.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public EmpleadosContables EmpleadosContables { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleadoscontables = await _context.EmpleadosContables.FirstOrDefaultAsync(m => m.Id == id);

            if (empleadoscontables is not null)
            {
                EmpleadosContables = empleadoscontables;

                return Page();
            }

            return NotFound();
        }
    }
}
