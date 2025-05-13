using SharedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LOGClassLibrary
{
    public interface IModService
    {
        Task<List<Mod>> GetLatestModsAsync();
    }
}

