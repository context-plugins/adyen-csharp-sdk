using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of Resource, PaymentInstrumentResource.
/// </summary>
[JsonConverter(typeof(PaymentInstrumentResourceConverter))]
public record PaymentInstrumentResource
{
    public required Resource Resource { get; init; }

    public required PaymentInstrumentResourceProperties PaymentInstrumentResourceProperties { get; init; }

    public void Deconstruct(out Resource resource,
        out PaymentInstrumentResourceProperties paymentInstrumentResourceProperties)
    {
        resource = Resource;
        paymentInstrumentResourceProperties = PaymentInstrumentResourceProperties;
    }

    public static implicit operator Resource(PaymentInstrumentResource value) => value.Resource;

    public static implicit operator PaymentInstrumentResourceProperties(PaymentInstrumentResource value) =>
        value.PaymentInstrumentResourceProperties;
}

file class PaymentInstrumentResourceConverter : JsonConverter<PaymentInstrumentResource>
{
    public override PaymentInstrumentResource Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var resource = root.Deserialize<Resource>(options) ??
            throw new JsonException("Failed to deserialize Resource");
        var paymentInstrumentResourceProperties = root.Deserialize<PaymentInstrumentResourceProperties>(options) ??
            throw new JsonException("Failed to deserialize PaymentInstrumentResourceProperties");
        return new PaymentInstrumentResource
        {
            Resource = resource,
            PaymentInstrumentResourceProperties = paymentInstrumentResourceProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        PaymentInstrumentResource value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var resourceJson = JsonSerializer.SerializeToElement(value.Resource, options);
        foreach (var property in resourceJson.EnumerateObject())
            property.WriteTo(writer);
        var paymentInstrumentResourcePropertiesJson =
            JsonSerializer.SerializeToElement(value.PaymentInstrumentResourceProperties, options);
        foreach (var property in paymentInstrumentResourcePropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
