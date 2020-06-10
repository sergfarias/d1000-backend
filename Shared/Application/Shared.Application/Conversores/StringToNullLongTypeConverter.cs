using AutoMapper;

namespace Shared.Application.Conversores
{
    // Automapper string to decimal?
    public class StringToNullLongTypeConverter : ITypeConverter<string, long?>
    {
        public long? Convert(string source, long? destination, ResolutionContext context)
        {
            if (source == null)
                return null;
            else
            {
                return long.TryParse(source, out long result) ? (long?)result : null;
            }
        }
    }
}
