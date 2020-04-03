// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ScoringProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (TextWeights != null)
            {
                writer.WritePropertyName("text");
                writer.WriteObjectValue(TextWeights);
            }
            if (Functions != null)
            {
                writer.WritePropertyName("functions");
                writer.WriteStartArray();
                foreach (var item in Functions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (FunctionAggregation != null)
            {
                writer.WritePropertyName("functionAggregation");
                writer.WriteStringValue(FunctionAggregation.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static ScoringProfile DeserializeScoringProfile(JsonElement element)
        {
            string name = default;
            TextWeights text = default;
            IList<ScoringFunction> functions = default;
            ScoringFunctionAggregation? functionAggregation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = TextWeights.DeserializeTextWeights(property.Value);
                    continue;
                }
                if (property.NameEquals("functions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringFunction> array = new List<ScoringFunction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ScoringFunction.DeserializeScoringFunction(item));
                        }
                    }
                    functions = array;
                    continue;
                }
                if (property.NameEquals("functionAggregation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    functionAggregation = property.Value.GetString().ToScoringFunctionAggregation();
                    continue;
                }
            }
            return new ScoringProfile(name, text, functions, functionAggregation);
        }
    }
}
