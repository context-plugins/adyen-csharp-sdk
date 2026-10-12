using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

[JsonConverter(typeof(EventsDatumConverter))]
public record EventsDatum
{
    private readonly Optional<MerchantPurchaseData> _merchantPurchaseDataValue;

    private readonly Optional<IssuingTransactionData> _issuingTransactionDataValue;

    private readonly Optional<InterchangeData> _interchangeDataValue;

    private EventsDatum(Optional<MerchantPurchaseData> merchantPurchaseDataValue,
        Optional<IssuingTransactionData> issuingTransactionDataValue,
        Optional<InterchangeData> interchangeDataValue)
    {
        _merchantPurchaseDataValue = merchantPurchaseDataValue;
        _issuingTransactionDataValue = issuingTransactionDataValue;
        _interchangeDataValue = interchangeDataValue;
    }

    public static EventsDatum MerchantPurchaseData(MerchantPurchaseData value) =>
        new(Optional<MerchantPurchaseData>.Some(value), default, default);

    public static EventsDatum IssuingTransactionData(IssuingTransactionData value) =>
        new(default, Optional<IssuingTransactionData>.Some(value), default);

    public static EventsDatum InterchangeData(InterchangeData value) =>
        new(default, default, Optional<InterchangeData>.Some(value));

    public bool TryGetMerchantPurchaseData(out MerchantPurchaseData value) =>
        _merchantPurchaseDataValue.TryGetValue(out value);

    public bool TryGetIssuingTransactionData(out IssuingTransactionData value) =>
        _issuingTransactionDataValue.TryGetValue(out value);

    public bool TryGetInterchangeData(out InterchangeData value) => _interchangeDataValue.TryGetValue(out value);

    public static implicit operator EventsDatum(MerchantPurchaseData value) => MerchantPurchaseData(value);

    public static implicit operator EventsDatum(IssuingTransactionData value) => IssuingTransactionData(value);

    public static implicit operator EventsDatum(InterchangeData value) => InterchangeData(value);
}

file sealed class EventsDatumConverter : JsonConverter<EventsDatum>
{
    public override EventsDatum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "merchantPurchaseData" => EventsDatum.MerchantPurchaseData(root.Deserialize<MerchantPurchaseData>(
                options)!),
            "issuingTransactionData" => EventsDatum.IssuingTransactionData(root.Deserialize<IssuingTransactionData>(
                options)!),
            "interchangeData" => EventsDatum.InterchangeData(root.Deserialize<InterchangeData>(options)!),
            _ => throw new JsonException(
                $"JSON does not match MerchantPurchaseData or IssuingTransactionData or InterchangeData schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, EventsDatum value, JsonSerializerOptions options)
    {
        if (value.TryGetMerchantPurchaseData(out var merchantPurchaseDataValue))
        {
            JsonSerializer.Serialize(writer, merchantPurchaseDataValue, options);
        }
        else if (value.TryGetIssuingTransactionData(out var issuingTransactionDataValue))
        {
            JsonSerializer.Serialize(writer, issuingTransactionDataValue, options);
        }
        else if (value.TryGetInterchangeData(out var interchangeDataValue))
        {
            JsonSerializer.Serialize(writer, interchangeDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EventsDatum)} contains no valid value to serialize.");
        }
    }
}
