using AutoMapper;
using Shared.Domain.Impl;
using System;
using System.Globalization;

namespace Shared.Application.Conversores
{
    // Automapper string to DateTime
    public class StringToDateTimeTypeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            if (source == null)
                throw new ArgumentNullException(Textos.Shared_Mensagem_Erro_String_To_DateTime);

            DateTime.TryParseExact(source, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

            return result;
        }
    }
}
