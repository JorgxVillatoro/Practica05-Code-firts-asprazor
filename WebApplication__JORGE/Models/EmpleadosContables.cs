using System.ComponentModel.DataAnnotations;

namespace WebApplication_JORGE.Models
{
    public class EmpleadosContables : Employee
    {
        public int RegistrosCreados { get; set; }
        public int FacturasCreadas { get; set; }
    }
}
