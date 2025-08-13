namespace PDFManagerV2.Core.utils
{
    public static class FechaFormatter
    {
        public static string FormatearFechaLarga(DateTime fecha)
        {
            return $"{fecha.Day} de {MesEnEspanol(fecha.Month)} del {fecha.Year}";
        }

        private static string MesEnEspanol(int mes)
        {
            string[] meses = {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };
            return meses[mes - 1];
        }
    }
}