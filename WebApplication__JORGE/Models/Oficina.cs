using System.ComponentModel.DataAnnotations;

namespace WebApplication_JORGE.Models
{
    public class Oficina
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = default!;
        [Required(ErrorMessage = "La dirección es obligatoria")]
        public string Direccion { get; set; } = default!;
        public string? Telefono { get; set; }
    }
}
