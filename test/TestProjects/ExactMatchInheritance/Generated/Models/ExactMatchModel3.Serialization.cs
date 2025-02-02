// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ExactMatchInheritance.Models
{
    public partial class ExactMatchModel3 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(New))
            {
                writer.WritePropertyName("new");
                writer.WriteStringValue(New);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Bar))
            {
                writer.WritePropertyName("bar");
                writer.WriteStringValue(Bar);
            }
            writer.WriteEndObject();
        }

        internal static ExactMatchModel3 DeserializeExactMatchModel3(JsonElement element)
        {
            Optional<string> @new = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<string> bar = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("new"))
                {
                    @new = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bar"))
                {
                    bar = property.Value.GetString();
                    continue;
                }
            }
            return new ExactMatchModel3(id.Value, name.Value, bar.Value, @new.Value);
        }
    }
}
