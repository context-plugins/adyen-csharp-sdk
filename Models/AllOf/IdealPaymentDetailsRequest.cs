using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of PaymentDetailsRequest, IdealPaymentDetailsRequest.
/// </summary>
[JsonConverter(typeof(IdealPaymentDetailsRequestConverter))]
public record IdealPaymentDetailsRequest
{
    public required PaymentDetailsRequest PaymentDetailsRequest { get; init; }

    public required IdealPaymentDetailsRequestProperties IdealPaymentDetailsRequestProperties { get; init; }

    public void Deconstruct(out PaymentDetailsRequest paymentDetailsRequest,
        out IdealPaymentDetailsRequestProperties idealPaymentDetailsRequestProperties)
    {
        paymentDetailsRequest = PaymentDetailsRequest;
        idealPaymentDetailsRequestProperties = IdealPaymentDetailsRequestProperties;
    }

    public static implicit operator PaymentDetailsRequest(IdealPaymentDetailsRequest value) =>
        value.PaymentDetailsRequest;

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
        var paymentDetailsRequest = root.Deserialize<PaymentDetailsRequest>(options) ??
            throw new JsonException("Failed to deserialize PaymentDetailsRequest");
        var idealPaymentDetailsRequestProperties = root.Deserialize<IdealPaymentDetailsRequestProperties>(options) ??
            throw new JsonException("Failed to deserialize IdealPaymentDetailsRequestProperties");
        return new IdealPaymentDetailsRequest
        {
            PaymentDetailsRequest = paymentDetailsRequest,
            IdealPaymentDetailsRequestProperties = idealPaymentDetailsRequestProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        IdealPaymentDetailsRequest value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var paymentDetailsRequestJson = JsonSerializer.SerializeToElement(value.PaymentDetailsRequest, options);
        foreach (var property in paymentDetailsRequestJson.EnumerateObject())
            property.WriteTo(writer);
        var idealPaymentDetailsRequestPropertiesJson =
            JsonSerializer.SerializeToElement(value.IdealPaymentDetailsRequestProperties, options);
        foreach (var property in idealPaymentDetailsRequestPropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
