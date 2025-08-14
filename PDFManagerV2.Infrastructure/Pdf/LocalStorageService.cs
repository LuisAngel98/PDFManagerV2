using iTextSharp.text.pdf;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;
using PDFManagerV2.UseCases.Recibos.Interfaces;

namespace PDFManagerV2.Infrastructure.Pdf
{
    public class LocalStorageService : IFileStorageService
    {
        private readonly IAppSettings _appSettings;
        public LocalStorageService(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public async Task<Result<string>> SaveAsync(Recibo recibo)
        {
            var fileName = $"{recibo.Cliente.Dni}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            byte[] pdfBytes = Shared.Properties.Resources.template_recibo;
            string outputPath = _appSettings.PdfOutputPath;
            string fullFilePath = Path.Combine(outputPath, fileName);

            using var msInput = new MemoryStream(pdfBytes);
            using var reader = new PdfReader(msInput);
            using var fs = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write);
            using (var stamper = new PdfStamper(reader, fs))
            {
                var form = stamper.AcroFields;

                void SetIfExists(string fieldName, string value)
                {
                    if (form.Fields.ContainsKey(fieldName))
                    {
                        form.SetField(fieldName, value);
                        Console.WriteLine($"✅ Campo '{fieldName}' rellenado.");
                    }
                    else
                    {
                        Console.WriteLine($"⚠️ Campo '{fieldName}' no encontrado.");
                    }
                }

                SetIfExists("Concepto", recibo.Concepto);
                SetIfExists("Dni", recibo.Cliente.Dni);
                SetIfExists("Fecha", recibo.FechaEmisionFormateada);
                SetIfExists("Monto", recibo.MontoFormateado);
                SetIfExists("RecibiDe", recibo.Cliente.Nombres + ", " + recibo.Cliente.Apellidos);

                // 📌 Metadata PDF
                var info = stamper.MoreInfo ?? new Dictionary<string, string>();
                info["Author"] = $"{recibo.Cliente.Nombres} {recibo.Cliente.Apellidos}";
                stamper.MoreInfo = info;

                stamper.FormFlattening = true;
            }

            return Result<string>.Success(fullFilePath);
        }
    }
}