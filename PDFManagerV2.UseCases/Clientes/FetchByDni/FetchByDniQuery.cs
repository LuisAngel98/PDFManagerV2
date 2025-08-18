using MediatR;
using PDFManagerV2.Core;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Clientes.FetchByDni
{
    public record FetchByDniQuery (string Dni) : IRequest<Result<Cliente>>;
}
