using AutoMapper;

namespace Shared.Application.Conversores
{
    // Automapper bool to int
    public class StringToBooleanToIntTypeConverter : ITypeConverter<bool, int>
    {
        public int Convert(bool source, int destination, ResolutionContext context)
        {
            if (!source)
                return -1;
            else
                return 0;
        }
    }
}
