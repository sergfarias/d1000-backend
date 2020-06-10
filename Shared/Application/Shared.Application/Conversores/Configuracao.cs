using AutoMapper;
using System;

namespace Shared.Application.Conversores
{
    // Automap type converter definitions for 
    // int, int?, decimal, decimal?, bool, bool?, Int64, Int64?, DateTime
    public class Configuracao
    {
        public static void Registrar(Profile configurationProfile)
        {
            configurationProfile.CreateMap<string, int?>().ConvertUsing(new StringToNullIntTypeConverter());
            configurationProfile.CreateMap<string, int>().ConvertUsing(new StringToIntTypeConverter());

            configurationProfile.CreateMap<string, decimal?>().ConvertUsing(new StringToNullDecimalTypeConverter());
            configurationProfile.CreateMap<string, decimal>().ConvertUsing(new StringToDecimalTypeConverter());

            configurationProfile.CreateMap<string, double?>().ConvertUsing(new StringToNullDoubleTypeConverter());
            configurationProfile.CreateMap<string, double>().ConvertUsing(new StringToDoubleTypeConverter());

            configurationProfile.CreateMap<string, bool?>().ConvertUsing(new StringToNullBooleanTypeConverter());
            configurationProfile.CreateMap<string, bool>().ConvertUsing(new StringToBooleanTypeConverter());

            configurationProfile.CreateMap<bool, int>().ConvertUsing(new StringToBooleanToIntTypeConverter());

            configurationProfile.CreateMap<string, long?>().ConvertUsing(new StringToNullLongTypeConverter());
            configurationProfile.CreateMap<string, long>().ConvertUsing(new StringToLongTypeConverter());

            configurationProfile.CreateMap<string, DateTime?>().ConvertUsing(new StringToNullDateTimeTypeConverter());
            configurationProfile.CreateMap<string, DateTime>().ConvertUsing(new StringToDateTimeTypeConverter());
        }
    }
}
