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
    public class IndexModel : PageModel
    {
        private readonly WebApplication_JORGE.Data.ApplicationDbContext _context;

        public IndexModel(WebApplication_JORGE.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<EmpleadosContables> EmpleadosContables { get;set; } = default!;

        public async Task OnGetAsync()
        {
            EmpleadosContables = await _context.EmpleadosContables.ToListAsync();
        }
    }
}
