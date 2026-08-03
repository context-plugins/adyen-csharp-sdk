using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of ShopperIdPaymentMethod, PayToPaymentMethod.
/// </summary>
[JsonConverter(typeof(PayToPaymentMethodConverter))]
public record PayToPaymentMethod
{
    public required ShopperIdPaymentMethod ShopperIdPaymentMethod { get; init; }

    public void Deconstruct(out ShopperIdPaymentMethod shopperIdPaymentMethod)
    {
        shopperIdPaymentMethod = ShopperIdPaymentMethod;
    }

    public static implicit operator ShopperIdPaymentMethod(PayToPaymentMethod value) =>
        value.ShopperIdPaymentMethod;
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
        return new PayToPaymentMethod
        {
            ShopperIdPaymentMethod = shopperIdPaymentMethod,
        };
    }

    public override void Write(Utf8JsonWriter writer, PayToPaymentMethod value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var shopperIdPaymentMethodJson = JsonSerializer.SerializeToElement(value.ShopperIdPaymentMethod, options);
        foreach (var property in shopperIdPaymentMethodJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
