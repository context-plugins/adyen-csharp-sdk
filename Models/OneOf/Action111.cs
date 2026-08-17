using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models.OneOf;

/// <summary>
/// Action to be taken for completing the payment. When returned, only the 3D Secure action is needed in most cases.
/// </summary>
[JsonConverter(typeof(Action111Converter))]
public record Action111
{
    private readonly Optional<CheckoutThreeDs2Action> _checkoutThreeDs2ActionValue;

    private Action111(Optional<CheckoutThreeDs2Action> checkoutThreeDs2ActionValue)
    {
        _checkoutThreeDs2ActionValue = checkoutThreeDs2ActionValue;
    }

    public static Action111 CheckoutThreeDs2Action(CheckoutThreeDs2Action value) =>
        new(Optional<CheckoutThreeDs2Action>.Some(value));

    public bool TryGetCheckoutThreeDs2Action(out CheckoutThreeDs2Action value) =>
        _checkoutThreeDs2ActionValue.TryGetValue(out value);

    public static implicit operator Action111(CheckoutThreeDs2Action value) => CheckoutThreeDs2Action(value);
}

file sealed class Action111Converter : JsonConverter<Action111>
{
    public override Action111 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            throw new JsonException("Missing required 'type' discriminator field");
        }
        var discriminator = typeProperty.GetString();
        return discriminator switch
        {
            "threeDS2" => Action111.CheckoutThreeDs2Action(root.Deserialize<CheckoutThreeDs2Action>(options)!),
            _ => throw new JsonException($"JSON does not match CheckoutThreeDs2Action schemas: {root.ToString()}")
        };
    }

    public override void Write(Utf8JsonWriter writer, Action111 value, JsonSerializerOptions options)
    {
        if (value.TryGetCheckoutThreeDs2Action(out var checkoutThreeDs2ActionValue))
        {
            JsonSerializer.Serialize(writer, checkoutThreeDs2ActionValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(Action111)} contains no valid value to serialize.");
        }
    }
}
