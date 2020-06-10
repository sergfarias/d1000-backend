using AutoMapper;

namespace Shared.Application.Conversores
{
    // Automapper string to decimal?
    public class StringToNullDoubleTypeConverter : ITypeConverter<string, double?>
    {
        public double? Convert(string source, double? destination, ResolutionContext context)
        {
            if (source == null)
                return null;
            else
            {
                return double.TryParse(source, out double result) ? (double?)result : null;
            }
        }
    }
}
