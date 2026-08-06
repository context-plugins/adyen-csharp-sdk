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

    public required UpipaymentMethodProperties UpipaymentMethodProperties { get; init; }

    public void Deconstruct(out ShopperIdPaymentMethod shopperIdPaymentMethod,
        out UpipaymentMethodProperties upipaymentMethodProperties)
    {
        shopperIdPaymentMethod = ShopperIdPaymentMethod;
        upipaymentMethodProperties = UpipaymentMethodProperties;
    }

    public static implicit operator ShopperIdPaymentMethod(UpipaymentMethod value) => value.ShopperIdPaymentMethod;

    public static implicit operator UpipaymentMethodProperties(UpipaymentMethod value) =>
        value.UpipaymentMethodProperties;
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
        var upipaymentMethodProperties = root.Deserialize<UpipaymentMethodProperties>(options) ??
            throw new JsonException("Failed to deserialize UpipaymentMethodProperties");
        return new UpipaymentMethod
        {
            ShopperIdPaymentMethod = shopperIdPaymentMethod,
            UpipaymentMethodProperties = upipaymentMethodProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer, UpipaymentMethod value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var shopperIdPaymentMethodJson = JsonSerializer.SerializeToElement(value.ShopperIdPaymentMethod, options);
        foreach (var property in shopperIdPaymentMethodJson.EnumerateObject())
            property.WriteTo(writer);
        var upipaymentMethodPropertiesJson =
            JsonSerializer.SerializeToElement(value.UpipaymentMethodProperties, options);
        foreach (var property in upipaymentMethodPropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
