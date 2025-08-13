using MediatR;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.Create
{
    public record class CreateReciboCommand(string Dni, string Nombres, string Apellidos, decimal Monto, string Concepto) : IRequest<Result<string>>;
}