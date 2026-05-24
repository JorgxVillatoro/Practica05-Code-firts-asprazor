using System.ComponentModel.DataAnnotations;

namespace WebApplication_JORGE.Models
{
    public class EmpleadoDeveloper : Employee
    {
        public int BugsReparados { get; set; }
        public int AplicacionesCreadas { get; set; }
    }
}