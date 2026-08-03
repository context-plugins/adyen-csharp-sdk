using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The settings for online donations collected as part of the campaign.
/// </summary>
[JsonConverter(typeof(Online2Converter))]
public record Online2
{
    private readonly Optional<OnlineDonationSettingsUpdate> _onlineDonationSettingsUpdateValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private Online2(Optional<OnlineDonationSettingsUpdate> onlineDonationSettingsUpdateValue,
        Optional<object?> anonymousObjectValue)
    {
        _onlineDonationSettingsUpdateValue = onlineDonationSettingsUpdateValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static Online2 OnlineDonationSettingsUpdate(OnlineDonationSettingsUpdate value) =>
        new(Optional<OnlineDonationSettingsUpdate>.Some(value), default);

    public static Online2 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetOnlineDonationSettingsUpdate(out OnlineDonationSettingsUpdate value) =>
        _onlineDonationSettingsUpdateValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator Online2(OnlineDonationSettingsUpdate value) =>
        OnlineDonationSettingsUpdate(value);
}

file sealed class Online2Converter : JsonConverter<Online2>
{
    public override Online2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<OnlineDonationSettingsUpdate>(root,
            options,
            out var onlineDonationSettingsUpdateValue))
        {
            return Online2.OnlineDonationSettingsUpdate(onlineDonationSettingsUpdateValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return Online2.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match OnlineDonationSettingsUpdate or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, Online2 value, JsonSerializerOptions options)
    {
        if (value.TryGetOnlineDonationSettingsUpdate(out var onlineDonationSettingsUpdateValue))
        {
            JsonSerializer.Serialize(writer, onlineDonationSettingsUpdateValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Online2)} contains no valid value to serialize.");
        }
    }
}
