using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models.AnyOf;

/// <summary>
/// The type of donation to collect from the shopper. Possible values:
/// <list type="bullet">
///   <item><description><b>roundup</b>: Round up the transaction amount.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>fixedAmounts</b>: Choose a fixed amount.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>fixedAmountsRoundup</b>: Round up, or choose a fixed amount.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(DonationType4Converter))]
public record DonationType4
{
    private readonly Optional<DonationType> _donationTypeValue;

    private DonationType4(Optional<DonationType> donationTypeValue)
    {
        _donationTypeValue = donationTypeValue;
    }

    public static DonationType4 DonationType(DonationType value) => new(Optional<DonationType>.Some(value));

    public bool TryGetDonationType(out DonationType value) => _donationTypeValue.TryGetValue(out value);

    public static implicit operator DonationType4(DonationType value) => DonationType(value);
}

file sealed class DonationType4Converter : JsonConverter<DonationType4>
{
    public override DonationType4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DonationType>(root, options, out var donationTypeValue))
        {
            return DonationType4.DonationType(donationTypeValue);
        }
        throw new JsonException($"JSON does not match DonationType schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DonationType4 value, JsonSerializerOptions options)
    {
        if (value.TryGetDonationType(out var donationTypeValue))
        {
            JsonSerializer.Serialize(writer, donationTypeValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DonationType4)} contains no valid value to serialize.");
        }
    }
}
