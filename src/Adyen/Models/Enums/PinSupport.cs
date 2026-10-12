using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// PIN Support. For ecommerce, PIN is required.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PinSupport>))]
public sealed record PinSupport : OpenStringEnum<PinSupport>
{
    private PinSupport(string value) : base(value)
    {
    }

    public static readonly PinSupport Pin = new("PIN");

    public static readonly PinSupport NoPin = new("NO PIN");

    public TResult Match<TResult>(Func<TResult> onPin, Func<TResult> onNoPin, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pin => onPin(),
            _ when this == NoPin => onNoPin(),
            _ => otherwise(Value)
        };

    public void Match(Action onPin, Action onNoPin, Action<string> otherwise)
    {
        if (this == Pin) onPin();
        else if (this == NoPin) onNoPin();
        else otherwise(Value);
    }
}
