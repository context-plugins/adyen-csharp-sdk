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

    public void Deconstruct(out PaymentDetailsRequest paymentDetailsRequest)
    {
        paymentDetailsRequest = PaymentDetailsRequest;
    }

    public static implicit operator PaymentDetailsRequest(IdealPaymentDetailsRequest value) =>
        value.PaymentDetailsRequest;
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
        return new IdealPaymentDetailsRequest
        {
            PaymentDetailsRequest = paymentDetailsRequest,
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
        writer.WriteEndObject();
    }
}
