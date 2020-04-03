// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class KeysResult
    {
        internal static KeysResult DeserializeKeysResult(JsonElement element)
        {
            IReadOnlyDictionary<string, IList<string>> clusters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusters"))
                {
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    clusters = dictionary;
                    continue;
                }
            }
            return new KeysResult(clusters);
        }
    }
}
