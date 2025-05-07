using Microsoft.EntityFrameworkCore;
using RevokPlaza.Models;

namespace RevokPlaza.wwwroot.css
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mod> Mods { get; set; }  // This will map to the "Mods" table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map the "Mods" table
            modelBuilder.Entity<Mod>().ToTable("Mod");

            // Map properties to their respective columns
            modelBuilder.Entity<Mod>().Property(m => m.ModID).HasColumnName("ModId");
            modelBuilder.Entity<Mod>().Property(m => m.Name).HasColumnName("Name");
            modelBuilder.Entity<Mod>().Property(m => m.ModType).HasColumnName("Type");
            modelBuilder.Entity<Mod>().Property(m => m.Description).HasColumnName("Description");
            modelBuilder.Entity<Mod>().Property(m => m.DownloadLink).HasColumnName("DownloadLink");
            modelBuilder.Entity<Mod>().Property(m => m.UploadDate).HasColumnName("UploadDate");
            modelBuilder.Entity<Mod>().Property(m => m.AuthorID).HasColumnName("AuthorID");
            modelBuilder.Entity<Mod>().Property(m => m.ImageUrl).HasColumnName("ImageUrl");

        }
    }
}
