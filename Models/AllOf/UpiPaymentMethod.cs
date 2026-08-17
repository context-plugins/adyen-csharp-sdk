using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adyen.Models.AllOf;

/// <summary>
/// All Of ShopperIdPaymentMethod, UPIPaymentMethod.
/// </summary>
[JsonConverter(typeof(UpiPaymentMethodConverter))]
public record UpiPaymentMethod
{
    public required ShopperIdPaymentMethod ShopperIdPaymentMethod { get; init; }

    public required UpiPaymentMethodProperties UpiPaymentMethodProperties { get; init; }

    public void Deconstruct(out ShopperIdPaymentMethod shopperIdPaymentMethod,
        out UpiPaymentMethodProperties upiPaymentMethodProperties)
    {
        shopperIdPaymentMethod = ShopperIdPaymentMethod;
        upiPaymentMethodProperties = UpiPaymentMethodProperties;
    }

    public static implicit operator ShopperIdPaymentMethod(UpiPaymentMethod value) => value.ShopperIdPaymentMethod;

    public static implicit operator UpiPaymentMethodProperties(UpiPaymentMethod value) =>
        value.UpiPaymentMethodProperties;
}

file class UpiPaymentMethodConverter : JsonConverter<UpiPaymentMethod>
{
    public override UpiPaymentMethod Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var shopperIdPaymentMethod = root.Deserialize<ShopperIdPaymentMethod>(options) ??
            throw new JsonException("Failed to deserialize ShopperIdPaymentMethod");
        var upiPaymentMethodProperties = root.Deserialize<UpiPaymentMethodProperties>(options) ??
            throw new JsonException("Failed to deserialize UpiPaymentMethodProperties");
        return new UpiPaymentMethod
        {
            ShopperIdPaymentMethod = shopperIdPaymentMethod,
            UpiPaymentMethodProperties = upiPaymentMethodProperties,
        };
    }

    public override void Write(Utf8JsonWriter writer, UpiPaymentMethod value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        var shopperIdPaymentMethodJson = JsonSerializer.SerializeToElement(value.ShopperIdPaymentMethod, options);
        foreach (var property in shopperIdPaymentMethodJson.EnumerateObject())
            property.WriteTo(writer);
        var upiPaymentMethodPropertiesJson =
            JsonSerializer.SerializeToElement(value.UpiPaymentMethodProperties, options);
        foreach (var property in upiPaymentMethodPropertiesJson.EnumerateObject())
            property.WriteTo(writer);
        writer.WriteEndObject();
    }
}
