using System;
using AutoMapper;

namespace Shared.Application.Conversores
{
    // Automapper string to int?
    public class StringToNullIntTypeConverter : ITypeConverter<string, int?>
    {
        public int? Convert(string source, int? destination, ResolutionContext context)
        {
            if (source == null)
                return null;
            else
            {
                return Int32.TryParse(source, out int result) ? (int?)result : null;
            }
        }
    }
}
