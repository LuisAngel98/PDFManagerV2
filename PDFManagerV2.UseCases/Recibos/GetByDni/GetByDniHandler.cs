using MediatR;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;
using PDFManagerV2.UseCases.Interfaces;

namespace PDFManagerV2.UseCases.Recibos.GetByDni
{
    public class GetByDniHandler : IRequestHandler<GetByDniQuery, Result<List<Recibo>>>
    {
        private readonly IFileStorageService _fileStorageService;
        public GetByDniHandler(IFileStorageService fileStorageService)
        {
            _fileStorageService = fileStorageService;
        }
        public async Task<Result<List<Recibo>>> Handle(GetByDniQuery request, CancellationToken cancellationToken)
        {
            return await _fileStorageService.GetByDniAsync(request.Dni);
        }
    }
}