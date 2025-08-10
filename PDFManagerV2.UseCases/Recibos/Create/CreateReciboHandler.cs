using MediatR;
using PDFManagerV2.Shared;
using PDFManagerV2.UseCases.Recibos.Interfaces;

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
            var fileName = $"{request.Dni}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            var result = await _fileStorageService.SaveAsync(fileName);
            return Result<string>.Success(result.Value);
        }
    }
}