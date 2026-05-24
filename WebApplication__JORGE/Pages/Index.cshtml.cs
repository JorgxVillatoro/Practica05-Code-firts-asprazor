using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_JORGE.Pages
{
    public class IndexModel : PageModel
    {
        public int DiasTranscurridos { get; set; }
        public DateTime FechaCreacion { get; set; }

        public void OnGet()
        {
            // Fecha fija en que se creó la página (Año, Mes, Día)
            FechaCreacion = new DateTime(2026, 5, 10);

            // Calculamos la diferencia con el día de hoy en tiempo real
            DiasTranscurridos = (DateTime.Now - FechaCreacion).Days;
        }
    }
}