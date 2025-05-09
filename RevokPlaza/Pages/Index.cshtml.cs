using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedModels;
using LOGClassLibrary;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace RevokPlaza.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IModService _modService;

        public IndexModel(IModService modService)
        {
            _modService = modService;
        }

        public List<Mod> FeaturedMods { get; set; } = new();
        public List<Mod> Mods { get; set; } = new();

        public async Task OnGetAsync()
        {
            Mods = await _modService.GetLatestModsAsync();
            FeaturedMods = Mods.Take(4).ToList();
        }
    }
}
