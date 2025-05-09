using DALClassLibrary;
using Microsoft.EntityFrameworkCore;
using SharedModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOGClassLibrary
{
    public class ModService : IModService
    {
        private readonly AppDbContext _context;

        public ModService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Mod>> GetLatestModsAsync()
        {
            return await _context.Mods
                .OrderByDescending(m => m.UploadDate)
                .Take(20)
                .ToListAsync();
        }
    }
}
