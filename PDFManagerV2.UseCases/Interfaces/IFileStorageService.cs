using PDFManagerV2.Core;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Interfaces
{
    public interface IFileStorageService
    {
        Task<Result<string>> SaveAsync(Recibo archivo);
        Task<Result<List<Recibo>>> GetByDniAsync(string dni);
    }
}