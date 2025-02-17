// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoveResourceJobStatus
    {
        internal static MoveResourceJobStatus DeserializeMoveResourceJobStatus(JsonElement element)
        {
            Optional<MoveResourceJobName> jobName = default;
            Optional<string> jobProgress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobName = new MoveResourceJobName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobProgress"))
                {
                    jobProgress = property.Value.GetString();
                    continue;
                }
            }
            return new MoveResourceJobStatus(Optional.ToNullable(jobName), jobProgress.Value);
        }
    }
}
