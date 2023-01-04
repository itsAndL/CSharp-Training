using TechCompaniesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCompaniesLibrary.Services
{
    public class TechCompaniesService
    {
        private string JsonPath { get; set; } = @"C:\Users\lenovo\source\repos\SiliconValleyApp\SiliconValleyLibrary\data\techCompanies.json";
        private DataAccessService db = new();

        public List<CompanyModel> GetTechCompanies()
        {
            return db.LoadData<CompanyModel>(JsonPath);
        }
        public void InsertCompany(CompanyModel company) => db.SavaData<CompanyModel>(JsonPath, company);
    }
}
