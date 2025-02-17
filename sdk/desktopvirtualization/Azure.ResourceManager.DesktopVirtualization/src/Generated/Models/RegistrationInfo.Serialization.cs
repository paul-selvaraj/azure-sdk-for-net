// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class RegistrationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTime");
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(Token))
            {
                writer.WritePropertyName("token");
                writer.WriteStringValue(Token);
            }
            if (Optional.IsDefined(RegistrationTokenOperation))
            {
                writer.WritePropertyName("registrationTokenOperation");
                writer.WriteStringValue(RegistrationTokenOperation.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RegistrationInfo DeserializeRegistrationInfo(JsonElement element)
        {
            Optional<DateTimeOffset> expirationTime = default;
            Optional<string> token = default;
            Optional<RegistrationTokenOperation> registrationTokenOperation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expirationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("token"))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationTokenOperation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    registrationTokenOperation = new RegistrationTokenOperation(property.Value.GetString());
                    continue;
                }
            }
            return new RegistrationInfo(Optional.ToNullable(expirationTime), token.Value, Optional.ToNullable(registrationTokenOperation));
        }
    }
}
