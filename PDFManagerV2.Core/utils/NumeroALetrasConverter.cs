namespace PDFManagerV2.Core.utils
{
    public static class NumeroALetrasConverter
    {
        public static string Convertir(decimal valor, string moneda = "NUEVOS SOLES")
        {
            int parteEntera = (int)Math.Floor(valor);
            int parteDecimal = (int)Math.Round((valor - parteEntera) * 100);
            return $"S/. {valor:0.00} - {ConvertirEntero(parteEntera)} Y {parteDecimal:00}/100 {moneda}";
        }

        private static string ConvertirEntero(int numero)
        {
            string[] unidades = { "", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE",
                "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISÉIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE" };
            string[] decenas = { "", "DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
            string[] centenas = { "", "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };

            if (numero == 0) return "CERO";

            var letras = new System.Text.StringBuilder();

            int miles = numero / 1000;
            int restoMiles = numero % 1000;

            if (miles > 0)
            {
                if (miles == 1) letras.Append("MIL ");
                else letras.Append(ConvertirEntero(miles) + " MIL ");
            }

            int centenasNum = restoMiles / 100;
            int resto = restoMiles % 100;
            int decenasNum = resto / 10;
            int unidadesNum = resto % 10;

            if (centenasNum > 0)
            {
                if (resto == 0 && centenasNum == 1)
                    letras.Append("CIEN");
                else
                    letras.Append(centenas[centenasNum] + " ");
            }

            if (resto > 0)
            {
                if (resto < 20)
                    letras.Append(unidades[resto] + " ");
                else
                {
                    letras.Append(decenas[decenasNum]);
                    if (unidadesNum > 0)
                        letras.Append(" Y " + unidades[unidadesNum]);
                }
            }

            return letras.ToString().Trim();
        }
    }
}