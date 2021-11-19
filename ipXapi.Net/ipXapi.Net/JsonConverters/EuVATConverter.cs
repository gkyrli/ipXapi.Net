using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ipXapi.Net.JsonConverters
{
    public class EuVATConverter:JsonConverter<int?>
    {

            public override int? Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                return reader.TokenType switch
                {
                    JsonTokenType.False => null,
                    JsonTokenType.Number => reader.GetInt32()
                };
            }

            public override void Write(
                Utf8JsonWriter writer,
                int? intValue,
                JsonSerializerOptions options) =>
                writer.WriteStringValue(intValue?.ToString());
        
    }
}