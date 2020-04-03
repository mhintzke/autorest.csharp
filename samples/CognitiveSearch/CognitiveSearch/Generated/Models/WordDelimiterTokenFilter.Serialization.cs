// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class WordDelimiterTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (GenerateWordParts != null)
            {
                writer.WritePropertyName("generateWordParts");
                writer.WriteBooleanValue(GenerateWordParts.Value);
            }
            if (GenerateNumberParts != null)
            {
                writer.WritePropertyName("generateNumberParts");
                writer.WriteBooleanValue(GenerateNumberParts.Value);
            }
            if (CatenateWords != null)
            {
                writer.WritePropertyName("catenateWords");
                writer.WriteBooleanValue(CatenateWords.Value);
            }
            if (CatenateNumbers != null)
            {
                writer.WritePropertyName("catenateNumbers");
                writer.WriteBooleanValue(CatenateNumbers.Value);
            }
            if (CatenateAll != null)
            {
                writer.WritePropertyName("catenateAll");
                writer.WriteBooleanValue(CatenateAll.Value);
            }
            if (SplitOnCaseChange != null)
            {
                writer.WritePropertyName("splitOnCaseChange");
                writer.WriteBooleanValue(SplitOnCaseChange.Value);
            }
            if (PreserveOriginal != null)
            {
                writer.WritePropertyName("preserveOriginal");
                writer.WriteBooleanValue(PreserveOriginal.Value);
            }
            if (SplitOnNumerics != null)
            {
                writer.WritePropertyName("splitOnNumerics");
                writer.WriteBooleanValue(SplitOnNumerics.Value);
            }
            if (StemEnglishPossessive != null)
            {
                writer.WritePropertyName("stemEnglishPossessive");
                writer.WriteBooleanValue(StemEnglishPossessive.Value);
            }
            if (ProtectedWords != null)
            {
                writer.WritePropertyName("protectedWords");
                writer.WriteStartArray();
                foreach (var item in ProtectedWords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static WordDelimiterTokenFilter DeserializeWordDelimiterTokenFilter(JsonElement element)
        {
            bool? generateWordParts = default;
            bool? generateNumberParts = default;
            bool? catenateWords = default;
            bool? catenateNumbers = default;
            bool? catenateAll = default;
            bool? splitOnCaseChange = default;
            bool? preserveOriginal = default;
            bool? splitOnNumerics = default;
            bool? stemEnglishPossessive = default;
            IList<string> protectedWords = default;
            string odatatype = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generateWordParts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateWordParts = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("generateNumberParts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateNumberParts = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("catenateWords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catenateWords = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("catenateNumbers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catenateNumbers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("catenateAll"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catenateAll = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("splitOnCaseChange"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    splitOnCaseChange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preserveOriginal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveOriginal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("splitOnNumerics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    splitOnNumerics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stemEnglishPossessive"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stemEnglishPossessive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectedWords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
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
                    protectedWords = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odatatype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new WordDelimiterTokenFilter(odatatype, name, generateWordParts, generateNumberParts, catenateWords, catenateNumbers, catenateAll, splitOnCaseChange, preserveOriginal, splitOnNumerics, stemEnglishPossessive, protectedWords);
        }
    }
}
