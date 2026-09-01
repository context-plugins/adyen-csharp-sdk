using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of Resource, PaymentInstrumentResource.
/// </summary>
[JsonConverter(typeof(PaymentInstrumentResourceConverter))]
public record PaymentInstrumentResource
{
    public required Resource Resource { get; init; }

    public required PaymentInstrumentResourceProperties PaymentInstrumentResourceProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

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
        var extras =
            AdditionalProperties.SharedBy(resource.AdditionalProperties,
                paymentInstrumentResourceProperties.AdditionalProperties);
        resource.AdditionalProperties.Clear();
        paymentInstrumentResourceProperties.AdditionalProperties.Clear();
        return new PaymentInstrumentResource
        {
            Resource = resource,
            PaymentInstrumentResourceProperties = paymentInstrumentResourceProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer,
        PaymentInstrumentResource value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.Resource, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.PaymentInstrumentResourceProperties, options),
            written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
