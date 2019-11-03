using Microsoft.EntityFrameworkCore;

namespace AllinOneForDummies.Core
{
    public class DummiesContext : DbContext
    {
        public DummiesContext(DbContextOptions<DummiesContext> options) : base(options)
        { }

        public DbSet<Person> People { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Moon> Moons { get; set; }
        public DbSet<Star> Stars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-G67V9RV\SQLEXPRESS;Database=LearningDB;Trusted_Connection=True;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Planet>()
                .HasMany(a => a.Moons)
                .WithOne(a => a.Planet)
                .HasForeignKey(a => a.PlanetId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Star>()
                .HasMany(a => a.Planets)
                .WithOne(a => a.Star)
                .HasForeignKey(a => a.StarId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
