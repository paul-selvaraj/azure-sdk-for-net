// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AlertRuleCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(DataSource))
            {
                writer.WritePropertyName("dataSource");
                writer.WriteObjectValue(DataSource);
            }
            writer.WriteEndObject();
        }

        internal static AlertRuleCondition DeserializeAlertRuleCondition(JsonElement element)
        {
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Management.Insights.Models.LocationThresholdRuleCondition": return LocationThresholdRuleCondition.DeserializeLocationThresholdRuleCondition(element);
                    case "Microsoft.Azure.Management.Insights.Models.ManagementEventRuleCondition": return ManagementEventRuleCondition.DeserializeManagementEventRuleCondition(element);
                    case "Microsoft.Azure.Management.Insights.Models.ThresholdRuleCondition": return ThresholdRuleCondition.DeserializeThresholdRuleCondition(element);
                }
            }
            string odataType = default;
            Optional<RuleDataSource> dataSource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value);
                    continue;
                }
            }
            return new AlertRuleCondition(odataType, dataSource.Value);
        }
    }
}
