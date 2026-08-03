using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The default amount for donations.
/// </summary>
[JsonConverter(typeof(DefaultAmount2Converter))]
public record DefaultAmount2
{
    private readonly Optional<DonationAmountUpdate> _donationAmountUpdateValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private DefaultAmount2(Optional<DonationAmountUpdate> donationAmountUpdateValue,
        Optional<object?> anonymousObjectValue)
    {
        _donationAmountUpdateValue = donationAmountUpdateValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static DefaultAmount2 DonationAmountUpdate(DonationAmountUpdate value) =>
        new(Optional<DonationAmountUpdate>.Some(value), default);

    public static DefaultAmount2 AnonymousObject(object? value) =>
        new(default, Optional<object?>.Some(value));

    public bool TryGetDonationAmountUpdate(out DonationAmountUpdate value) =>
        _donationAmountUpdateValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator DefaultAmount2(DonationAmountUpdate value) => DonationAmountUpdate(value);
}

file sealed class DefaultAmount2Converter : JsonConverter<DefaultAmount2>
{
    public override DefaultAmount2 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DonationAmountUpdate>(root, options, out var donationAmountUpdateValue))
        {
            return DefaultAmount2.DonationAmountUpdate(donationAmountUpdateValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return DefaultAmount2.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match DonationAmountUpdate or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DefaultAmount2 value, JsonSerializerOptions options)
    {
        if (value.TryGetDonationAmountUpdate(out var donationAmountUpdateValue))
        {
            JsonSerializer.Serialize(writer, donationAmountUpdateValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DefaultAmount2)} contains no valid value to serialize.");
        }
    }
}
