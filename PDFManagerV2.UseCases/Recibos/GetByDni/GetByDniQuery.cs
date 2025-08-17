using MediatR;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.GetByDni
{
    public record class GetByDniQuery(string dni) : IRequest<Result<List<Recibo>>>;
}