using Microsoft.EntityFrameworkCore;
using MiMovieDatabase.Models;

namespace MiMovieDatabase.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        //public DbSet<MiMovieDatabase.Models.Movie> Movie { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Show>().ToTable("Show");
        }
    }
}
