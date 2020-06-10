using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Shared.Application.JsonConverters
{
    public class StringEnumJsonConverter : System.Text.Json.Serialization.JsonConverter<Enum>
    {
        public override Enum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (Enum)Enum.Parse(typeToConvert.GetType(), reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, Enum value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(Enum.GetName(value.GetType(), value));
        }

    }

}
