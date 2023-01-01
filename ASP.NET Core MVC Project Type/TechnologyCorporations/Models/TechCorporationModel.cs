using System.Text.Json;

namespace TechnologyCorporations.Models
{
    public class TechCorporationModel
    {
        public string ImageSource { get; set; }
        public string CorporationName { get; set; }
        public string CustomerService { get; set; }
        public string Founders { get; set; }
        public string Headquarters { get; set; }
        public string Founded { get; set; }

        public override string ToString() => JsonSerializer.Serialize<TechCorporationModel>(this);
    }
}
