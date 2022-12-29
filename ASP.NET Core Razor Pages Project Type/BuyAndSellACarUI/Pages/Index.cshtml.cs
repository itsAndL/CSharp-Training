using BuyAndSellACarLibrary.DataAccess;
using BuyAndSellACarLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuyAndSellACarUI.Pages
{
    public class IndexModel : PageModel
    {
        public List<Car> Cars { get; private set; }
        public void OnGet()
        {
            Cars = LoadListOfCars.GetCars();
        }
    }
}
