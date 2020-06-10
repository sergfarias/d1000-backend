using AutoMapper;
using Shared.Domain.Impl;
using System;
using System.Globalization;

namespace Shared.Application.Conversores
{
    // Automapper string to decimal?
    // Automapper string to decimal
    public class StringToDecimalTypeConverter : ITypeConverter<string, decimal>
    {
        public decimal Convert(string source, decimal destination, ResolutionContext context)
        {
            if (source == null)
                throw new ArgumentNullException(Textos.Shared_Mensagem_Erro_String_To_Decimal);
            else
            {
                string[] values = source.ToString().Split(new string[] { ",", "." }, StringSplitOptions.None);
                string decSeparator = CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator;
                var resultado = 0M;
                switch (values.Length)
                {
                    case 1:
                        resultado = Decimal.Parse(source + decSeparator + "00");
                        break;
                    case 2: //0,01 a 999,99
                        resultado = Decimal.Parse(values[0] + decSeparator + values[1]);
                        break;
                    case 3: //1.000,00 a 999.999,99
                        resultado = Decimal.Parse(values[0] + values[1] + decSeparator + values[2]);
                        break;
                    case 4: //1.000.000,00 a 9.999.999,00
                        resultado = Decimal.Parse(values[0] + values[1] + values[2] + decSeparator + values[3]);
                        break;
                    case 5: //1.000.000.000,00 a 9.999.999.999,99
                        resultado = Decimal.Parse(values[0] + values[1] + values[2] + values[3] + decSeparator + values[4]);
                        break;
                }
                return resultado;
            }
        }
    }
}
