using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using TRPITUSUserInterface.Models;
using TRPITUSUserInterface.Services;

namespace TRPITUSUserInterface.Pages
{
    public class InsertNewProfileModel : PageModel
    {
        private DataAccessService _daService;
        public InsertNewProfileModel(DataAccessService daService) => _daService = daService;

        [BindProperty]
        public Profile? NewProfile { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false) return Page();
            _daService.InsertProfile(NewProfile);
            return RedirectToPage("/Index");
        }
    }
}
