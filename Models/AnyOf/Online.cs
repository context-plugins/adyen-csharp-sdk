using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The settings for online donations collected as part of the campaign.
/// </summary>
[JsonConverter(typeof(OnlineConverter))]
public record Online
{
    private readonly Optional<OnlineDonationSettingsUpdate> _onlineDonationSettingsUpdateValue;

    private Online(Optional<OnlineDonationSettingsUpdate> onlineDonationSettingsUpdateValue)
    {
        _onlineDonationSettingsUpdateValue = onlineDonationSettingsUpdateValue;
    }

    public static Online OnlineDonationSettingsUpdate(OnlineDonationSettingsUpdate value) =>
        new(Optional<OnlineDonationSettingsUpdate>.Some(value));

    public bool TryGetOnlineDonationSettingsUpdate(out OnlineDonationSettingsUpdate value) =>
        _onlineDonationSettingsUpdateValue.TryGetValue(out value);

    public static implicit operator Online(OnlineDonationSettingsUpdate value) =>
        OnlineDonationSettingsUpdate(value);
}

file sealed class OnlineConverter : JsonConverter<Online>
{
    public override Online Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<OnlineDonationSettingsUpdate>(root,
            options,
            out var onlineDonationSettingsUpdateValue))
        {
            return Online.OnlineDonationSettingsUpdate(onlineDonationSettingsUpdateValue);
        }
        throw new JsonException($"JSON does not match OnlineDonationSettingsUpdate schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Online value, JsonSerializerOptions options)
    {
        if (value.TryGetOnlineDonationSettingsUpdate(out var onlineDonationSettingsUpdateValue))
        {
            JsonSerializer.Serialize(writer, onlineDonationSettingsUpdateValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Online)} contains no valid value to serialize.");
        }
    }
}
