using Microsoft.EntityFrameworkCore;
using MoviesProject.Models;

namespace MoviesProject
{
    public class appDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Nationality> Nationality { get; set; }
        public DbSet<Dirictor> dirictors { get; set; }
        public appDbContext(DbContextOptions<appDbContext> options):base(options) 
        {

        }
    }
}
