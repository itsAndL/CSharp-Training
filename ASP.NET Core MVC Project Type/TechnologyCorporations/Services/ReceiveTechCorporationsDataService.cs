using System.Text.Json;
using TechnologyCorporations.Models;

namespace TechnologyCorporations.Services
{
    public class ReceiveTechCorporationsDataService
    {
        private readonly IWebHostEnvironment WebHostEnvironment;
        public ReceiveTechCorporationsDataService(IWebHostEnvironment webHostEnvironment) 
        {
            WebHostEnvironment = webHostEnvironment;
        }

        private string jsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "TechCorporations.json");

        public List<TechCorporationModel> GetTechCorporations()
        {
            var reader = File.OpenText(jsonFileName);
            return JsonSerializer.Deserialize<List<TechCorporationModel>>(reader.ReadToEnd());
        }
    }
}
