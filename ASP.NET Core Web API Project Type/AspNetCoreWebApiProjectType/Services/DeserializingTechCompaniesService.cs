using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using AspNetCoreWebApiProjectType.Models;
using Microsoft.AspNetCore.Hosting;

namespace ContosoCrafts.WebSite.Services
{
    public class DeserializingTechCompaniesService
    {
        private string JsonFileName { get; } = @"C:\Users\lenovo\source\repos\AspNetCoreWebApiProjectType\AspNetCoreWebApiProjectType\techCompanies.json";

        public IEnumerable<TechCompanyModel> GetTechCompanies()
        {
            var jsonFileReader = File.OpenText(JsonFileName);
            return JsonSerializer.Deserialize<List<TechCompanyModel>>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
    }
}
