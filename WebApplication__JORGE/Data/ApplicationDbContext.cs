using Microsoft.EntityFrameworkCore;
using WebApplication_JORGE.Models;

namespace WebApplication_JORGE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Oficina> Oficinas { get; set; } = default!;
        public DbSet<Cliente> ClientesBD { get; set; } = default!;
        public DbSet<EmpleadosContables> EmpleadosContables { get; set; } = default!;
        public DbSet<EmpleadoDeveloper> EmpleadosDevelopers { get; set; } = default!;
    }
}
