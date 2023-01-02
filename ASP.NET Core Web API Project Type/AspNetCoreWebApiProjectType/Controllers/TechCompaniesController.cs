using AspNetCoreWebApiProjectType.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApiProjectType.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TechCompaniesController : Controller
    {
        public TechCompaniesController(DeserializingTechCompaniesService tCService) => TCService = tCService;
        private DeserializingTechCompaniesService TCService { get; set; }

        [HttpGet(Name = "GetTechCompanies")]
        public IEnumerable<TechCompanyModel> Get() => TCService.GetTechCompanies();
    }
}
