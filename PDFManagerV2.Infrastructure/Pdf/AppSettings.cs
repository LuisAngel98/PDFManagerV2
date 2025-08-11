using Microsoft.Extensions.Configuration;
using PDFManagerV2.UseCases.Recibos.Interfaces;

namespace PDFManagerV2.Infrastructure.Pdf
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfiguration _configuration;
        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public string PdfOutputPath => _configuration["AppSettings:PdfOutputPath"];
        public string PdfInputPath => _configuration["AppSettings:PdfInputPath"];
    }
}