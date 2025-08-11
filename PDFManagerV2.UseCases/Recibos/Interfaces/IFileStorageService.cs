using PDFManagerV2.Core;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.Interfaces
{
    public interface IFileStorageService
    {
        Task<Result<string>> SaveAsync(Recibo archivo);
    }
}