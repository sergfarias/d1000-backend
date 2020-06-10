using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Shared.CrossCutting.Tools
{
    public static class EnumExtensions
    {
        public static IList<TEnum> ToList<TEnum>()
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .ToList();
        }

        public static Dictionary<string, string> ToDictionary<TEnum>() where TEnum : struct
        {
            return System.Enum.GetValues(typeof(TEnum))
                .Cast<System.Enum>()
                .Select(item => new
                    {
                        key = (int)(object)item,
                        value = item.Descricao()
                })
                .OrderBy(x => x.value)
                .ToDictionary(x => x.key.ToString(), x => x.value)
                ;
        }
        public static TAttribute Atributo<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var enumType = value.GetType();

            var name = Enum.GetName(enumType, value);

            return enumType.GetField(name)
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }

        public static string Descricao(this System.Enum @enum)
        {
            if (@enum == null)
                return null;

            var enumItem = @enum.GetType()
                            .GetMember(@enum.ToString())
                            .FirstOrDefault();

            if (enumItem == null)
                return string.Empty;

            var attribute = enumItem.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attribute == null || attribute.Length == 0)
                return @enum.ToString();

            return (attribute[0] as DescriptionAttribute).Description;
        }

        public static TEnum RecuperarEnumPorAtributo<TEnum, TAttribute>
           (this string valor, Func<TAttribute, string> propriedade) where TAttribute : Attribute
        {
            var type = typeof(TEnum);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(TAttribute)) as TAttribute;
                if (attribute != null)
                {
                    if (propriedade.Invoke(attribute) == valor)
                        return (TEnum)field.GetValue(null);
                }
                else
                {
                    if (field.Name == valor)
                        return (TEnum)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "text");
            // or return default(T);
        }

        public static int ValorNumerico(this System.Enum @enum)
        {
            return Convert.ToInt16(@enum);
        }

        public static string Valor(this System.Enum @enum)
        {
            return Convert.ToInt16(@enum).ToString();
        }

        public static TEnum ToEnum<TEnum>(this string item, bool retornarValaoPadrao = false)
            where TEnum : struct
        {
            var enumExiste = Enum.GetNames(typeof(TEnum)).Any(x => x.ToLower() == item);

            if (retornarValaoPadrao && !enumExiste)
                return default(TEnum);

            return (TEnum)Enum.Parse(typeof(TEnum), item, true);
        }
    }
}
