// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class StorageSkuInformation
    {
        internal static StorageSkuInformation DeserializeStorageSkuInformation(JsonElement element)
        {
            StorageSkuName name = default;
            Optional<StorageSkuTier> tier = default;
            Optional<string> resourceType = default;
            Optional<StorageKind> kind = default;
            Optional<IReadOnlyList<string>> locations = default;
            Optional<IReadOnlyList<SKUCapability>> capabilities = default;
            Optional<IReadOnlyList<Restriction>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new StorageSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tier = property.Value.GetString().ToStorageSkuTier();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new StorageKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SKUCapability> array = new List<SKUCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SKUCapability.DeserializeSKUCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Restriction> array = new List<Restriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Restriction.DeserializeRestriction(item));
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new StorageSkuInformation(name, Optional.ToNullable(tier), resourceType.Value, Optional.ToNullable(kind), Optional.ToList(locations), Optional.ToList(capabilities), Optional.ToList(restrictions));
        }
    }
}
