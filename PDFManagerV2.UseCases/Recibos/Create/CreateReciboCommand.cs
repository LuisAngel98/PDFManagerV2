using MediatR;
using PDFManagerV2.Shared;

namespace PDFManagerV2.UseCases.Recibos.Create
{
    record class CreateReciboCommand(string Dni, string Nombres, string Apellidos, string Monto, string Concepto) : IRequest<Result<string>>;
}