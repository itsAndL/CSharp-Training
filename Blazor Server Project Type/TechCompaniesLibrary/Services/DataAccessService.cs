using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TechCompaniesLibrary.Services
{
    public class DataAccessService
    {
        public void SavaData<T>(string path, T item) where T : class
        {
            List<T> data = LoadData<T>(path);
            data.Add(item);

            var serializing = JsonSerializer.Serialize<List<T>>(data);

            File.WriteAllText(path, serializing);
        }

        public List<T> LoadData<T>(string path) where T : class
        {
            var reader = File.OpenText(path);

            var data = JsonSerializer.Deserialize<List<T>>(reader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            reader.Close();

            return data;
        }
    }
}
