using System.ComponentModel.DataAnnotations;

namespace WebApplication_JORGE.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = default!;
    }
}