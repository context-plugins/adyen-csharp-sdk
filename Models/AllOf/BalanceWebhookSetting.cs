using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of WebhookSetting, BalanceWebhookSetting.
/// </summary>
[JsonConverter(typeof(BalanceWebhookSettingConverter))]
public record BalanceWebhookSetting
{
    public required WebhookSetting WebhookSetting { get; init; }

    public required BalanceWebhookSettingProperties BalanceWebhookSettingProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out WebhookSetting webhookSetting,
        out BalanceWebhookSettingProperties balanceWebhookSettingProperties)
    {
        webhookSetting = WebhookSetting;
        balanceWebhookSettingProperties = BalanceWebhookSettingProperties;
    }

    public static implicit operator WebhookSetting(BalanceWebhookSetting value) => value.WebhookSetting;

    public static implicit operator BalanceWebhookSettingProperties(BalanceWebhookSetting value) =>
        value.BalanceWebhookSettingProperties;
}

file class BalanceWebhookSettingConverter : JsonConverter<BalanceWebhookSetting>
{
    public override BalanceWebhookSetting Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var webhookSetting = root.Deserialize<WebhookSetting>(options) ??
            throw new JsonException("Failed to deserialize WebhookSetting");
        var balanceWebhookSettingProperties = root.Deserialize<BalanceWebhookSettingProperties>(options) ??
            throw new JsonException("Failed to deserialize BalanceWebhookSettingProperties");
        var extras =
            AdditionalProperties.SharedBy(webhookSetting.AdditionalProperties,
                balanceWebhookSettingProperties.AdditionalProperties);
        webhookSetting.AdditionalProperties.Clear();
        balanceWebhookSettingProperties.AdditionalProperties.Clear();
        return new BalanceWebhookSetting
        {
            WebhookSetting = webhookSetting,
            BalanceWebhookSettingProperties = balanceWebhookSettingProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer, BalanceWebhookSetting value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.WebhookSetting, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.BalanceWebhookSettingProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
