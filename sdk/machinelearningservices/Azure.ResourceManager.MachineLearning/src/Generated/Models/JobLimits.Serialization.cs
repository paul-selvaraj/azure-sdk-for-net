// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class JobLimits : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("jobLimitsType");
            writer.WriteStringValue(JobLimitsType.ToString());
            if (Optional.IsDefined(Timeout))
            {
                if (Timeout != null)
                {
                    writer.WritePropertyName("timeout");
                    writer.WriteStringValue(Timeout.Value, "P");
                }
                else
                {
                    writer.WriteNull("timeout");
                }
            }
            writer.WriteEndObject();
        }

        internal static JobLimits DeserializeJobLimits(JsonElement element)
        {
            if (element.TryGetProperty("jobLimitsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Sweep": return SweepJobLimits.DeserializeSweepJobLimits(element);
                    case "Command": return CommandJobLimits.DeserializeCommandJobLimits(element);
                }
            }
            JobLimitsType jobLimitsType = default;
            Optional<TimeSpan?> timeout = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobLimitsType"))
                {
                    jobLimitsType = new JobLimitsType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeout = null;
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
            }
            return new JobLimits(jobLimitsType, Optional.ToNullable(timeout));
        }
    }
}
