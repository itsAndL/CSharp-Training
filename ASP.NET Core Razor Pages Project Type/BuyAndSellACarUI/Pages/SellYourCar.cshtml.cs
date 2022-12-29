using BuyAndSellACarLibrary.DataAccess;
using BuyAndSellACarLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuyAndSellACarUI.Pages
{
    public class SellYourCarModel : PageModel
    {
        [BindProperty]
        public Car NewCar { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false) return Page();
            AddNewCar.Add(NewCar);
            return RedirectToPage("/Index");
        }
    }
}
