namespace PDFManagerV2.Core
{
    public class Recibo
    {
        public string Codigo { get; set; }
        public string Monto { get; set; }
        public string Concepto { get; set; }
        public string FechaEmision { get; set; }
        public Cliente Cliente { get; set; }
    }
}