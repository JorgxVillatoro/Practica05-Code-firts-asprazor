using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_JORGE.Data;
using WebApplication_JORGE.Models;

namespace WebApplication__JORGE.Pages.Oficinas
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public DetailsModel(WebApplication_JORGE.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Oficina Oficina { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oficina = await _context.Oficinas.FirstOrDefaultAsync(m => m.Id == id);

            if (oficina is not null)
            {
                Oficina = oficina;

                return Page();
            }

            return NotFound();
        }
    }
}
