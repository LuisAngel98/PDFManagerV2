using Microsoft.Extensions.Configuration;
using PDFManagerV2.UseCases.Interfaces;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PDFManagerV2.Infrastructure.Pdf
{
    public class AppSettings : IAppSettings
    {
        private readonly string _filePath;

        public AppSettings()
        {
            _filePath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        }

        private JsonNode LoadConfig()
        {
            var json = File.ReadAllText(_filePath);
            return JsonNode.Parse(json)!;
        }

        public string PdfOutputPath => LoadConfig()["AppSettings"]?["PdfOutputPath"]?.ToString() ?? string.Empty;
        public string PdfInputPath => LoadConfig()["AppSettings"]?["PdfInputPath"]?.ToString() ?? string.Empty;
        public string ReniecApiKey => LoadConfig()["AppSettings"]?["ReniecApiKey"]?.ToString() ?? string.Empty;

        public void UpdateSetting(string key, string value)
        {
            var json = File.ReadAllText(_filePath);
            var node = JsonNode.Parse(json)!;

            node["AppSettings"]![key] = value;

            File.WriteAllText(_filePath, node.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}