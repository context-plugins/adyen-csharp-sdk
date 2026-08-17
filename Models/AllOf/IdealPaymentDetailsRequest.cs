using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of PaymentDetailsRequest1, IdealPaymentDetailsRequest.
/// </summary>
[JsonConverter(typeof(IdealPaymentDetailsRequestConverter))]
public record IdealPaymentDetailsRequest
{
    public required PaymentDetailsRequest1 PaymentDetailsRequest1 { get; init; }

    public required IdealPaymentDetailsRequestProperties IdealPaymentDetailsRequestProperties { get; init; }

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
        return new IdealPaymentDetailsRequest
        {
            PaymentDetailsRequest1 = paymentDetailsRequest1,
            IdealPaymentDetailsRequestProperties = idealPaymentDetailsRequestProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IdealPaymentDetailsRequest value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var paymentDetailsRequest1Json = JsonSerializer.SerializeToElement(value.PaymentDetailsRequest1, options);
        foreach (var property in paymentDetailsRequest1Json.EnumerateObject())
            property.WriteTo(writer);
        var idealPaymentDetailsRequestPropertiesJson =
            JsonSerializer.SerializeToElement(value.IdealPaymentDetailsRequestProperties, options);
        foreach (var property in idealPaymentDetailsRequestPropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
