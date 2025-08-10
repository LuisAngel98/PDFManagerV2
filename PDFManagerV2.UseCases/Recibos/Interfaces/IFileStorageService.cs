using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.Interfaces
{
    public interface IFileStorageService
    {
        Task<Result<string>> SaveAsync(string archivo);
    }
}