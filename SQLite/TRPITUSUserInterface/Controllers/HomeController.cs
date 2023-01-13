using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TRPITUSLibrary.Models;
using TRPITUSLibrary.Services;
using TRPITUSUserInterface.Models;

namespace TRPITUSUserInterface.Controllers
{
    public class HomeController : Controller
    {
        private List<ProfileModel> Profiles { get; set; }
        private SQLiteDataAccessService _daService;
        public HomeController(SQLiteDataAccessService daService) => _daService = daService;
        public IActionResult Index()
        {
            string sql = "select * from main.FullProfile";
            Profiles = _daService.GetProfiles<ProfileModel>(sql);
            return View(Profiles);
        }

        public IActionResult InsertNewProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertNewProfile(DisplayProfileModel dProfile)
        {
            if(ModelState.IsValid) 
            {
                string sql = "insert into Profile(Name, Age, Residence, Citizenship, MaritalStatus, Children, Education, ImageSource) values(@Name, @Age, @Residence, @Citizenship, @MaritalStatus, @Children, @Education, @ImageSource); insert into Ranking(Rank, NetWorth, Source, Industry) values(@Rank, @NetWorth, @Source, @Industry)";

                ProfileModel profile = new()
                {
                    Name = dProfile.Name,
                    Age = dProfile.Age,
                    Residence = dProfile.Residence,
                    Citizenship = dProfile.Citizenship,
                    MaritalStatus = dProfile.MaritalStatus,
                    Children = dProfile.Children,
                    Education = dProfile.Education,
                    ImageSource = dProfile.ImageSource,
                    Rank = dProfile.Rank,
                    NetWorth = dProfile.NetWorth,
                    Source = dProfile.Source,
                    Industry = dProfile.Industry
                };

                _daService.InsertProfile(sql, profile);

                return RedirectToAction("Index");
            }

            return View();
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
