using EcommProject.Models;
using Microsoft.EntityFrameworkCore;


namespace EcommProject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            //Relationship between the tables (Many to Many)
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies).HasForeignKey(
                    m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor)
                .WithMany(am => am.Actors_Movies).HasForeignKey(
                    m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        //Creating the tables for the models in DB
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
    }
}
