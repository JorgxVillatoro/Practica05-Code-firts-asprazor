using System.ComponentModel.DataAnnotations;

namespace WebApplication_JORGE.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = default!;
        [Required(ErrorMessage = "El correo es obligatorio"), EmailAddress]
        public string Correo { get; set; } = default!;
    }
}