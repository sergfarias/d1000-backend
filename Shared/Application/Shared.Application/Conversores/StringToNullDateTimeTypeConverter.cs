using System;
using System.Globalization;
using AutoMapper;

namespace Shared.Application.Conversores
{
    // Automapper string to DateTime?
    public class StringToNullDateTimeTypeConverter : ITypeConverter<string, DateTime?>
    {
        public DateTime? Convert(string source, DateTime? destination, ResolutionContext context)
        {
            if (source == null)
                return null;

            return DateTime.TryParseExact(source, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) ? (DateTime?)result : null;
        }
    }
}
