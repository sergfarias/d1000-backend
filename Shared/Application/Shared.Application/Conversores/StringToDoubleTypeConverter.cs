using AutoMapper;
using Shared.Domain.Impl;
using System;

namespace Shared.Application.Conversores
{
    // Automapper string to double
    public class StringToDoubleTypeConverter : ITypeConverter<string, double>
    {
        public double Convert(string source, double destination, ResolutionContext context)
        {
            if (source == null)
                throw new ArgumentNullException(Textos.Shared_Mensagem_Erro_String_To_Double);
            else
                return double.Parse(source);
        }
    }
}
