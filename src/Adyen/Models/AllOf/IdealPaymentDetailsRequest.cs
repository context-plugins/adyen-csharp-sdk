using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of PaymentDetailsRequest1, IdealPaymentDetailsRequest.
/// </summary>
[JsonConverter(typeof(IdealPaymentDetailsRequestConverter))]
public record IdealPaymentDetailsRequest
{
    public required PaymentDetailsRequest1 PaymentDetailsRequest1 { get; init; }

    public required IdealPaymentDetailsRequestProperties IdealPaymentDetailsRequestProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out PaymentDetailsRequest1 paymentDetailsRequest1,
        out IdealPaymentDetailsRequestProperties idealPaymentDetailsRequestProperties)
    {
        paymentDetailsRequest1 = PaymentDetailsRequest1;
        idealPaymentDetailsRequestProperties = IdealPaymentDetailsRequestProperties;
    }

    public static implicit operator PaymentDetailsRequest1(IdealPaymentDetailsRequest value) =>
        value.PaymentDetailsRequest1;

    public static implicit operator IdealPaymentDetailsRequestProperties(IdealPaymentDetailsRequest value) =>
        value.IdealPaymentDetailsRequestProperties;
}

file class IdealPaymentDetailsRequestConverter : JsonConverter<IdealPaymentDetailsRequest>
{
    public override IdealPaymentDetailsRequest Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var paymentDetailsRequest1 = root.Deserialize<PaymentDetailsRequest1>(options) ??
            throw new JsonException("Failed to deserialize PaymentDetailsRequest1");
        var idealPaymentDetailsRequestProperties = root.Deserialize<IdealPaymentDetailsRequestProperties>(options) ??
            throw new JsonException("Failed to deserialize IdealPaymentDetailsRequestProperties");
        var extras =
            AdditionalProperties.SharedBy(
                paymentDetailsRequest1.AdditionalProperties,
                idealPaymentDetailsRequestProperties.AdditionalProperties);
        paymentDetailsRequest1.AdditionalProperties.Clear();
        idealPaymentDetailsRequestProperties.AdditionalProperties.Clear();
        return new IdealPaymentDetailsRequest
        {
            PaymentDetailsRequest1 = paymentDetailsRequest1,
            IdealPaymentDetailsRequestProperties = idealPaymentDetailsRequestProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer, IdealPaymentDetailsRequest value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.PaymentDetailsRequest1, options), written);
        writer.WriteUnwritten(
            JsonSerializer.SerializeToElement(value.IdealPaymentDetailsRequestProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
