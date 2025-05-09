using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedModels;



namespace DALClassLibrary
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Mod> Mods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mod>().ToTable("Mod");

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
