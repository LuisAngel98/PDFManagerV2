
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.Interfaces
{
    public class LocalStorageService : IFileStorageService
    {
        public async Task<Result<string>> SaveAsync(string path)
        {
            return Result<string>.Success(path);
        }
    }
}