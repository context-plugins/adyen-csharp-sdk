using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AnyOf;

[JsonConverter(typeof(EventsDatumConverter))]
public record EventsDatum
{
    private readonly Optional<InterchangeData> _interchangeDataValue;

    private readonly Optional<IssuingTransactionData> _issuingTransactionDataValue;

    private readonly Optional<MerchantPurchaseData> _merchantPurchaseDataValue;

    private EventsDatum(Optional<InterchangeData> interchangeDataValue,
        Optional<IssuingTransactionData> issuingTransactionDataValue,
        Optional<MerchantPurchaseData> merchantPurchaseDataValue)
    {
        _interchangeDataValue = interchangeDataValue;
        _issuingTransactionDataValue = issuingTransactionDataValue;
        _merchantPurchaseDataValue = merchantPurchaseDataValue;
    }

    public static EventsDatum InterchangeData(InterchangeData value) =>
        new(Optional<InterchangeData>.Some(value), default, default);

    public static EventsDatum IssuingTransactionData(IssuingTransactionData value) =>
        new(default, Optional<IssuingTransactionData>.Some(value), default);

    public static EventsDatum MerchantPurchaseData(MerchantPurchaseData value) =>
        new(default, default, Optional<MerchantPurchaseData>.Some(value));

    public bool TryGetInterchangeData(out InterchangeData value) =>
        _interchangeDataValue.TryGetValue(out value);

    public bool TryGetIssuingTransactionData(out IssuingTransactionData value) =>
        _issuingTransactionDataValue.TryGetValue(out value);

    public bool TryGetMerchantPurchaseData(out MerchantPurchaseData value) =>
        _merchantPurchaseDataValue.TryGetValue(out value);

    public static implicit operator EventsDatum(InterchangeData value) => InterchangeData(value);

    public static implicit operator EventsDatum(IssuingTransactionData value) => IssuingTransactionData(value);

    public static implicit operator EventsDatum(MerchantPurchaseData value) => MerchantPurchaseData(value);
}

file sealed class EventsDatumConverter : JsonConverter<EventsDatum>
{
    public override EventsDatum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<InterchangeData>(root, options, out var interchangeDataValue))
        {
            return EventsDatum.InterchangeData(interchangeDataValue);
        }
        if (JsonSerializer.TryDeserialize<IssuingTransactionData>(root,
            options,
            out var issuingTransactionDataValue))
        {
            return EventsDatum.IssuingTransactionData(issuingTransactionDataValue);
        }
        if (JsonSerializer.TryDeserialize<MerchantPurchaseData>(root, options, out var merchantPurchaseDataValue))
        {
            return EventsDatum.MerchantPurchaseData(merchantPurchaseDataValue);
        }
        throw new JsonException($"JSON does not match InterchangeData or IssuingTransactionData or MerchantPurchaseData schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, EventsDatum value, JsonSerializerOptions options)
    {
        if (value.TryGetInterchangeData(out var interchangeDataValue))
        {
            JsonSerializer.Serialize(writer, interchangeDataValue, options);
        }
        else if (value.TryGetIssuingTransactionData(out var issuingTransactionDataValue))
        {
            JsonSerializer.Serialize(writer, issuingTransactionDataValue, options);
        }
        else if (value.TryGetMerchantPurchaseData(out var merchantPurchaseDataValue))
        {
            JsonSerializer.Serialize(writer, merchantPurchaseDataValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(EventsDatum)} contains no valid value to serialize.");
        }
    }
}
