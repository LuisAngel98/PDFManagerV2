using iTextSharp.text.pdf;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;
using PDFManagerV2.UseCases.Interfaces;
using System.Globalization;

namespace PDFManagerV2.Infrastructure.Pdf
{
    public class LocalStorageService : IFileStorageService
    {
        private readonly IAppSettings _appSettings;
        public LocalStorageService(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async Task<Result<List<Recibo>>> GetByDniAsync(string dni)
        {
            try
            {
                string inputPath = _appSettings.PdfInputPath;
                var recibos = new List<Recibo>();

                //Patrón de búsqueda: si no hay DNI, traer todos los PDF
                string searchPattern = string.IsNullOrWhiteSpace(dni) ? "*.pdf" : $"{dni}*.pdf";

                foreach (var file in Directory.GetFiles(inputPath, searchPattern))
                {
                    using var reader = new PdfReader(file);
                    var info = reader.Info;

                    string author = info.ContainsKey("Author") ? info["Author"] : string.Empty;

                    //Extraer datos desde el nombre del archivo
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    var parts = fileName.Split('-');

                    if (parts.Length != 3)
                        continue; // Formato inválido, saltar

                    string dniArchivo = parts[0];
                    string fechaPart = parts[1];
                    string horaPart = parts[2];

                    if (!DateTime.TryParseExact(
                            fechaPart + horaPart,
                            "ddMMyyyyHHmmss",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out DateTime fechaEmision))
                    {
                        continue; // Fecha inválida, saltar
                    }

                    //Construir objeto Recibo
                    recibos.Add(new Recibo
                    {
                        Cliente = new Cliente
                        {
                            Dni = dniArchivo,
                            Nombres = author.Split(' ').FirstOrDefault() ?? string.Empty,
                            Apellidos = string.Join(" ", author.Split(' ').Skip(1))
                        },
                        FechaEmision = fechaEmision
                    });
                }

                return Result<List<Recibo>>.Success(recibos);
            }
            catch (Exception ex)
            {
                return Result<List<Recibo>>.Failure($"Error al obtener recibos: {ex.Message}");
            }
        }

        public async Task<Result<string>> SaveAsync(Recibo recibo)
        {
            var fileName = $"{recibo.Cliente.Dni}-{DateTime.Now:ddMMyyyy}-{DateTime.Now:HHmmss}.pdf";
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

                // Metadata PDF
                var info = stamper.MoreInfo ?? new Dictionary<string, string>();
                info["Author"] = $"{recibo.Cliente.Nombres}, {recibo.Cliente.Apellidos}";
                stamper.MoreInfo = info;

                stamper.FormFlattening = true;
            }

            return Result<string>.Success(fullFilePath);
        }
    }
}