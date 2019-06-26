﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Text.Json.Serialization.Converters
{
    internal sealed class JsonConverterUInt16 : JsonConverter<ushort>
    {
        public override ushort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.Number)
            {
                ThrowHelper.ThrowJsonException();
            }

            return reader.GetUInt16();
        }

        public override void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }

        public override void Write(Utf8JsonWriter writer, ushort value, JsonEncodedText propertyName, JsonSerializerOptions options)
        {
            writer.WriteNumber(propertyName, value);
        }
    }
}
