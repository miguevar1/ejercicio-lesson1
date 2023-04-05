using Microsoft.EntityFrameworkCore;
using EjercicioLesson1.Models.DataModels;

namespace EjercicioLesson1.DataAccess
{
    public class EjercicioDBContext : DbContext
    {
        public EjercicioDBContext(DbContextOptions<EjercicioDBContext> options) : base (options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Curso { get; set; }

    }
}
