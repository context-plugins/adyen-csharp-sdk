using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The settings for in-person donations collected as part of the campaign.
/// </summary>
[JsonConverter(typeof(InPerson2Converter))]
public record InPerson2
{
    private readonly Optional<InPersonDonationSettingsUpdate> _inPersonDonationSettingsUpdateValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private InPerson2(Optional<InPersonDonationSettingsUpdate> inPersonDonationSettingsUpdateValue,
        Optional<object?> anonymousObjectValue)
    {
        _inPersonDonationSettingsUpdateValue = inPersonDonationSettingsUpdateValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static InPerson2 InPersonDonationSettingsUpdate(InPersonDonationSettingsUpdate value) =>
        new(Optional<InPersonDonationSettingsUpdate>.Some(value), default);

    public static InPerson2 AnonymousObject(object? value) => new(default, Optional<object?>.Some(value));

    public bool TryGetInPersonDonationSettingsUpdate(out InPersonDonationSettingsUpdate value) =>
        _inPersonDonationSettingsUpdateValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator InPerson2(InPersonDonationSettingsUpdate value) =>
        InPersonDonationSettingsUpdate(value);
}

file sealed class InPerson2Converter : JsonConverter<InPerson2>
{
    public override InPerson2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<InPersonDonationSettingsUpdate>(root,
            options,
            out var inPersonDonationSettingsUpdateValue))
        {
            return InPerson2.InPersonDonationSettingsUpdate(inPersonDonationSettingsUpdateValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return InPerson2.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match InPersonDonationSettingsUpdate or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, InPerson2 value, JsonSerializerOptions options)
    {
        if (value.TryGetInPersonDonationSettingsUpdate(out var inPersonDonationSettingsUpdateValue))
        {
            JsonSerializer.Serialize(writer, inPersonDonationSettingsUpdateValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(InPerson2)} contains no valid value to serialize.");
        }
    }
}
