namespace PDFManagerV2.UseCases.Recibos.Interfaces
{
    public interface IAppSettings
    {
        string PdfOutputPath { get; }
        string PdfInputPath { get; }
    }
}