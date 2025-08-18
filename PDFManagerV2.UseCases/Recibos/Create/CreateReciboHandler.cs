using MediatR;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;
using PDFManagerV2.UseCases.Interfaces;

namespace PDFManagerV2.UseCases.Recibos.Create
{
    public class CreateReciboHandler : IRequestHandler<CreateReciboCommand, Result<string>>
    {
        private readonly IFileStorageService _fileStorageService;   
        public CreateReciboHandler(IFileStorageService fileStorageService)
        {
            _fileStorageService = fileStorageService;
        }
        async Task<Result<string>> IRequestHandler<CreateReciboCommand, Result<string>>.Handle(CreateReciboCommand request, CancellationToken cancellationToken)
        {
            var recibo = new Recibo
            {
                Monto = request.Monto,
                Concepto = request.Concepto,
                FechaEmision = DateTime.Now,
                Cliente = new Cliente
                {
                    Dni = request.Dni,
                    Nombres = request.Nombres,
                    Apellidos = request.Apellidos
                }
            };
            var result = await _fileStorageService.SaveAsync(recibo);
            if (result.IsFailure)
            {
                return Result<string>.Failure($"Error al guardar el recibo:");
            }
            return Result<string>.Success(result.Value);
        }
    }
}