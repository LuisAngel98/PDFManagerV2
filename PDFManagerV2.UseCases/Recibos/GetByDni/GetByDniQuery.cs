using MediatR;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.GetByDni
{
    public record GetByDniQuery(string Dni) : IRequest<Result<List<Recibo>>>;
}