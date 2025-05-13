using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DALClassLibrary;
using SharedModels; // This is where your Mod class is

namespace RevoKPlaza.Pages.Mod
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public SharedModels.Mod Mod { get; set; }

        public IActionResult OnGet(int id)
        {
            Mod = _context.Mods.FirstOrDefault(m => m.ModID == id);
            if (Mod == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

