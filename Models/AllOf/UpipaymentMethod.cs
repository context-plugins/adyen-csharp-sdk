using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of ShopperIdPaymentMethod, UPIPaymentMethod.
/// </summary>
[JsonConverter(typeof(UpipaymentMethodConverter))]
public record UpipaymentMethod
{
    public required ShopperIdPaymentMethod ShopperIdPaymentMethod { get; init; }

    public void Deconstruct(out ShopperIdPaymentMethod shopperIdPaymentMethod)
    {
        shopperIdPaymentMethod = ShopperIdPaymentMethod;
    }

    public static implicit operator ShopperIdPaymentMethod(UpipaymentMethod value) => value.ShopperIdPaymentMethod;
}

file class UpipaymentMethodConverter : JsonConverter<UpipaymentMethod>
{
    public override UpipaymentMethod Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var shopperIdPaymentMethod = root.Deserialize<ShopperIdPaymentMethod>(options) ??
            throw new JsonException("Failed to deserialize ShopperIdPaymentMethod");
        return new UpipaymentMethod
        {
            ShopperIdPaymentMethod = shopperIdPaymentMethod,
        };
    }

    public override void Write(Utf8JsonWriter writer, UpipaymentMethod value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var shopperIdPaymentMethodJson = JsonSerializer.SerializeToElement(value.ShopperIdPaymentMethod, options);
        foreach (var property in shopperIdPaymentMethodJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
