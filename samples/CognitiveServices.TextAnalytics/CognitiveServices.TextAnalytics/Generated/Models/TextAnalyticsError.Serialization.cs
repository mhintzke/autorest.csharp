// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    public partial class TextAnalyticsError
    {
        internal static TextAnalyticsError DeserializeTextAnalyticsError(JsonElement element)
        {
            ErrorCodeValue code = default;
            string message = default;
            string target = default;
            InnerError innerError = default;
            IReadOnlyList<TextAnalyticsError> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString().ToErrorCodeValue();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innerError = InnerError.DeserializeInnerError(property.Value);
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAnalyticsError> array = new List<TextAnalyticsError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DeserializeTextAnalyticsError(item));
                        }
                    }
                    details = array;
                    continue;
                }
            }
            return new TextAnalyticsError(code, message, target, innerError, details);
        }
    }
}
