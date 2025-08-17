namespace PDFManagerV2.UseCases.Recibos.Interfaces
{
    public interface IAppSettings
    {
        string PdfOutputPath { get; }
        string PdfInputPath { get; }
        void UpdateSetting(string key, string value);
    }
}