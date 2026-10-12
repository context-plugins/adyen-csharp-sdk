using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Extensions;
using Adyen.Core.Models;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of ShopperIdPaymentMethod, PayToPaymentMethod.
/// </summary>
[JsonConverter(typeof(PayToPaymentMethodConverter))]
public record PayToPaymentMethod
{
    public required ShopperIdPaymentMethod ShopperIdPaymentMethod { get; init; }

    public required PayToPaymentMethodProperties PayToPaymentMethodProperties { get; init; }

    public AdditionalProperties AdditionalProperties { get; init; } = [];

    public void Deconstruct(out ShopperIdPaymentMethod shopperIdPaymentMethod,
        out PayToPaymentMethodProperties payToPaymentMethodProperties)
    {
        shopperIdPaymentMethod = ShopperIdPaymentMethod;
        payToPaymentMethodProperties = PayToPaymentMethodProperties;
    }

    public static implicit operator ShopperIdPaymentMethod(PayToPaymentMethod value) => value.ShopperIdPaymentMethod;

    public static implicit operator PayToPaymentMethodProperties(PayToPaymentMethod value) =>
        value.PayToPaymentMethodProperties;
}

file class PayToPaymentMethodConverter : JsonConverter<PayToPaymentMethod>
{
    public override PayToPaymentMethod Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var shopperIdPaymentMethod = root.Deserialize<ShopperIdPaymentMethod>(options) ??
            throw new JsonException("Failed to deserialize ShopperIdPaymentMethod");
        var payToPaymentMethodProperties = root.Deserialize<PayToPaymentMethodProperties>(options) ??
            throw new JsonException("Failed to deserialize PayToPaymentMethodProperties");
        var extras =
            AdditionalProperties.SharedBy(
                shopperIdPaymentMethod.AdditionalProperties,
                payToPaymentMethodProperties.AdditionalProperties);
        shopperIdPaymentMethod.AdditionalProperties.Clear();
        payToPaymentMethodProperties.AdditionalProperties.Clear();
        return new PayToPaymentMethod
        {
            ShopperIdPaymentMethod = shopperIdPaymentMethod,
            PayToPaymentMethodProperties = payToPaymentMethodProperties,
            AdditionalProperties = extras,
        };
    }

    public override void Write(Utf8JsonWriter writer, PayToPaymentMethod value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var written = new HashSet<string>(StringComparer.Ordinal);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.ShopperIdPaymentMethod, options), written);
        writer.WriteUnwritten(JsonSerializer.SerializeToElement(value.PayToPaymentMethodProperties, options), written);
        writer.WriteUnwritten(value.AdditionalProperties, written);
        writer.WriteEndObject();
    }
}
