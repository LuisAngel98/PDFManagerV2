using MediatR;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;
using PDFManagerV2.UseCases.Interfaces;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace PDFManagerV2.UseCases.Clientes.FetchByDni
{
    public class FetchByDniHandler : IRequestHandler<FetchByDniQuery, Result<Cliente>>
    {
        private readonly IAppSettings _appSettings;
        public FetchByDniHandler(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public async Task<Result<Cliente>> Handle(FetchByDniQuery request, CancellationToken cancellationToken)
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _appSettings.ReniecApiKey);

            var body = new { dni = request.Dni };
            var response = await client.PostAsJsonAsync("https://apiperu.dev/api/dni", body);

            if (!response.IsSuccessStatusCode)
            {
                return Result<Cliente>.Failure("Error al consultar la API externa.");
            }

            var apiResponse = await response.Content.ReadFromJsonAsync<DniApiResponse>();

            if (apiResponse == null || !apiResponse.Success || apiResponse.Data == null)
            {
                return Result<Cliente>.Failure("No se encontró información para el DNI proporcionado.");
            }

            var cliente = new Cliente
            {
                Dni = apiResponse.Data.Numero,
                Nombres = apiResponse.Data.Nombres,
                Apellidos = $"{apiResponse.Data.ApellidoPaterno} {apiResponse.Data.ApellidoMaterno}"
            };

            return Result<Cliente>.Success(cliente);
        }
    }
    public class DniApiResponse
    {
        public bool Success { get; set; }
        public DniData Data { get; set; }
    }

    public class DniData
    {
        [JsonPropertyName("numero")]
        public string Numero { get; set; }

        [JsonPropertyName("nombre_completo")]
        public string NombreCompleto { get; set; }

        [JsonPropertyName("nombres")]
        public string Nombres { get; set; }

        [JsonPropertyName("apellido_paterno")]
        public string ApellidoPaterno { get; set; }

        [JsonPropertyName("apellido_materno")]
        public string ApellidoMaterno { get; set; }
    }
}
