using AutoMapper;
using Shared.Domain.Impl;
using System;

namespace Shared.Application.Conversores
{
    // Automapper string to int
    public class StringToIntTypeConverter : ITypeConverter<string, int>
    {
        public int Convert(string source, int destination, ResolutionContext context)
        {
            if (source == null)
                throw new ArgumentNullException(Textos.Shared_Mensagem_Erro_String_To_Int);
            else
                return Int32.Parse(source);
        }
    }
}
