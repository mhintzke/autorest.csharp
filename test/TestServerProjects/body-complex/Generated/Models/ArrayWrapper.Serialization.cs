// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class ArrayWrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Array != null)
            {
                writer.WritePropertyName("array");
                writer.WriteStartArray();
                foreach (var item in Array)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ArrayWrapper DeserializeArrayWrapper(JsonElement element)
        {
            IList<string> array = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("array"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array0 = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array0.Add(null);
                        }
                        else
                        {
                            array0.Add(item.GetString());
                        }
                    }
                    array = array0;
                    continue;
                }
            }
            return new ArrayWrapper(array);
        }
    }
}
