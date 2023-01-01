using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechnologyCorporations.Models;
using TechnologyCorporations.Services;

namespace TechnologyCorporations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ReceiveTechCorporationsDataService TechCorporationsService;


        public HomeController(ILogger<HomeController> logger, ReceiveTechCorporationsDataService techCorporationsService)
        {
            _logger = logger;
            TechCorporationsService = techCorporationsService;
        }

        public IActionResult Index()
        {
            List<TechCorporationModel> techCorporations = TechCorporationsService.GetTechCorporations();

            return View(techCorporations);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
