using PDFManagerV2.Core.utils;

namespace PDFManagerV2.Core
{
    public class Recibo
    {
        public string Codigo { get; set; }
        public decimal Monto { get; set; }
        public string MontoFormateado => NumeroALetrasConverter.Convertir(Monto);
        public string Concepto { get; set; }
        public DateTime FechaEmision { get; set; }
        public string FechaEmisionFormateada => FechaFormatter.FormatearFechaLarga(FechaEmision);
        public Cliente Cliente { get; set; }
    }
}