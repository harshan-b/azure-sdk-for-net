// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal partial class KeyVaultPrivateLinkResourceListResult
    {
        internal static KeyVaultPrivateLinkResourceListResult DeserializeKeyVaultPrivateLinkResourceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PrivateLinkResourceData> array = new List<PrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateLinkResourceData.DeserializePrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new KeyVaultPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
