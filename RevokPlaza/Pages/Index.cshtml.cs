using Microsoft.AspNetCore.Mvc.RazorPages;
using RevokPlaza.Data;
using RevokPlaza.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevokPlaza.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Mod> FeaturedMods { get; set; } = new();
        public List<Mod> Mods { get; set; } = new
            ();

        public async Task OnGetAsync()
        {
            // Load mods from the database
            Mods = await _context.Mods
                .OrderByDescending(m => m.UploadDate)  // Use UploadDate for sorting
                .Take(20)
                .ToListAsync();

            // Set featured mods (e.g., top 4 newest mods for now)
            FeaturedMods = Mods.Take(4).ToList();

        }
    }
}
