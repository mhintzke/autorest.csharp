// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ImmutabilityPolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (UpdateHistory != null)
            {
                writer.WritePropertyName("updateHistory");
                writer.WriteStartArray();
                foreach (var item in UpdateHistory)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ImmutabilityPeriodSinceCreationInDays != null)
            {
                writer.WritePropertyName("immutabilityPeriodSinceCreationInDays");
                writer.WriteNumberValue(ImmutabilityPeriodSinceCreationInDays.Value);
            }
            if (State != null)
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (AllowProtectedAppendWrites != null)
            {
                writer.WritePropertyName("allowProtectedAppendWrites");
                writer.WriteBooleanValue(AllowProtectedAppendWrites.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ImmutabilityPolicyProperties DeserializeImmutabilityPolicyProperties(JsonElement element)
        {
            string etag = default;
            IList<UpdateHistoryProperty> updateHistory = default;
            int? immutabilityPeriodSinceCreationInDays = default;
            ImmutabilityPolicyState? state = default;
            bool? allowProtectedAppendWrites = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateHistory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UpdateHistoryProperty> array = new List<UpdateHistoryProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(UpdateHistoryProperty.DeserializeUpdateHistoryProperty(item));
                        }
                    }
                    updateHistory = array;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("immutabilityPeriodSinceCreationInDays"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immutabilityPeriodSinceCreationInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new ImmutabilityPolicyState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowProtectedAppendWrites"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowProtectedAppendWrites = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ImmutabilityPolicyProperties(etag, updateHistory, immutabilityPeriodSinceCreationInDays, state, allowProtectedAppendWrites);
        }
    }
}
