using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The default amount for donations.
/// </summary>
[JsonConverter(typeof(DefaultAmountConverter))]
public record DefaultAmount
{
    private readonly Optional<DonationAmountUpdate> _donationAmountUpdateValue;

    private DefaultAmount(Optional<DonationAmountUpdate> donationAmountUpdateValue)
    {
        _donationAmountUpdateValue = donationAmountUpdateValue;
    }

    public static DefaultAmount DonationAmountUpdate(DonationAmountUpdate value) =>
        new(Optional<DonationAmountUpdate>.Some(value));

    public bool TryGetDonationAmountUpdate(out DonationAmountUpdate value) =>
        _donationAmountUpdateValue.TryGetValue(out value);

    public static implicit operator DefaultAmount(DonationAmountUpdate value) => DonationAmountUpdate(value);
}

file sealed class DefaultAmountConverter : JsonConverter<DefaultAmount>
{
    public override DefaultAmount Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DonationAmountUpdate>(root, options, out var donationAmountUpdateValue))
        {
            return DefaultAmount.DonationAmountUpdate(donationAmountUpdateValue);
        }
        throw new JsonException($"JSON does not match DonationAmountUpdate schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DefaultAmount value, JsonSerializerOptions options)
    {
        if (value.TryGetDonationAmountUpdate(out var donationAmountUpdateValue))
        {
            JsonSerializer.Serialize(writer, donationAmountUpdateValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DefaultAmount)} contains no valid value to serialize.");
        }
    }
}
