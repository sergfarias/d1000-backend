using System;
using AutoMapper;

namespace Shared.Application.Conversores
{
    // Automapper string to bool?
    public class StringToNullBooleanTypeConverter : ITypeConverter<string, bool?>
    {
        public bool? Convert(string source, bool? destination, ResolutionContext context)
        {
            if (source == null)
                return null;
            else
            {
                return Boolean.TryParse(source, out bool result) ? (bool?)result : null;
            }
        }
    }
}
