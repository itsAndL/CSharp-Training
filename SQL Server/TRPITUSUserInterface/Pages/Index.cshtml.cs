using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TRPITUSUserInterface.Models;
using TRPITUSUserInterface.Services;

namespace TRPITUSUserInterface.Pages
{
    public class IndexModel : PageModel
    {
        public List<Profile> Profiles { get; private set; }
        private DataAccessService _daServer;
        public IndexModel(DataAccessService daService) => _daServer = daService;

        public void OnGet()
        {
            Profiles = _daServer.GetProfiles();
        }
    }
}
