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
[JsonConverter(typeof(DonationType2Converter))]
public record DonationType2
{
    private readonly Optional<DonationType> _donationTypeValue;

    private readonly Optional<object?> _anonymousObjectValue;

    private DonationType2(Optional<DonationType> donationTypeValue, Optional<object?> anonymousObjectValue)
    {
        _donationTypeValue = donationTypeValue;
        _anonymousObjectValue = anonymousObjectValue;
    }

    public static DonationType2 DonationType(DonationType value) =>
        new(Optional<DonationType>.Some(value), default);

    public static DonationType2 AnonymousObject(object? value) =>
        new(default, Optional<object?>.Some(value));

    public bool TryGetDonationType(out DonationType value) => _donationTypeValue.TryGetValue(out value);

    public bool TryGetAnonymousObject(out object? value) => _anonymousObjectValue.TryGetValue(out value);

    public static implicit operator DonationType2(DonationType value) => DonationType(value);
}

file sealed class DonationType2Converter : JsonConverter<DonationType2>
{
    public override DonationType2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<DonationType>(root, options, out var donationTypeValue))
        {
            return DonationType2.DonationType(donationTypeValue);
        }
        if (JsonSerializer.TryDeserialize<object?>(root, options, out var anonymousObjectValue))
        {
            return DonationType2.AnonymousObject(anonymousObjectValue);
        }
        throw new JsonException($"JSON does not match DonationType or object? schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, DonationType2 value, JsonSerializerOptions options)
    {
        if (value.TryGetDonationType(out var donationTypeValue))
        {
            JsonSerializer.Serialize(writer, donationTypeValue, options);
        }
        else if (value.TryGetAnonymousObject(out var anonymousObjectValue))
        {
            JsonSerializer.Serialize(writer, anonymousObjectValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(DonationType2)} contains no valid value to serialize.");
        }
    }
}
