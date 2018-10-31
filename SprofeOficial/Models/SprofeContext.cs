using Microsoft.EntityFrameworkCore;

namespace Sprofe.Models
{
    public class SprofeContext : DbContext
    {
        public SpotifiContext(DbContextOptions<SprofeContext> options) 
        : base(options) {

        }
    

    public DbSet<Profesor> Profesores { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Alumno> Alumnos { get; set; }
    }
}
