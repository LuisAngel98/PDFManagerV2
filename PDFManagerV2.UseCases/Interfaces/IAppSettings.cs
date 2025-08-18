namespace PDFManagerV2.UseCases.Interfaces
{
    public interface IAppSettings
    {
        string PdfOutputPath { get; }
        string PdfInputPath { get; }
        string ReniecApiKey { get; }
        void UpdateSetting(string key, string value);
    }
}