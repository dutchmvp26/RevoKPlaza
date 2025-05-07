using Microsoft.EntityFrameworkCore;
using RevokPlaza.Models;

namespace MarioKartModManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Mod> Mods { get; set; }
        // Add other DbSets like Users, Comments, etc.
    }
}
