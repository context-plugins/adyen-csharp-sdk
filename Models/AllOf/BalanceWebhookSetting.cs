using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of WebhookSetting, BalanceWebhookSetting.
/// </summary>
[JsonConverter(typeof(BalanceWebhookSettingConverter))]
public record BalanceWebhookSetting
{
    public required WebhookSetting WebhookSetting { get; init; }

    public void Deconstruct(out WebhookSetting webhookSetting)
    {
        webhookSetting = WebhookSetting;
    }

    public static implicit operator WebhookSetting(BalanceWebhookSetting value) => value.WebhookSetting;
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
        return new BalanceWebhookSetting
        {
            WebhookSetting = webhookSetting,
        };
    }

    public override void Write(Utf8JsonWriter writer, BalanceWebhookSetting value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var webhookSettingJson = JsonSerializer.SerializeToElement(value.WebhookSetting, options);
        foreach (var property in webhookSettingJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
