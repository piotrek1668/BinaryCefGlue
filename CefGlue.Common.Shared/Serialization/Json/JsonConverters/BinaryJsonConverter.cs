﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Xilium.CefGlue.Common.Shared.Serialization.Json;

namespace Xilium.CefGlue.Common.Shared.Serialization.Json.JsonConverters
{
    internal class BinaryJsonConverter : JsonConverter<byte[]>
    {
        public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
        {
            // write byte[] with a special marker
            writer.WriteStringValue(DataMarkers.BinaryMarker + JsonSerializer.SerializeToNode(value));
        }
    }
}