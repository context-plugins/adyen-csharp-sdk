using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of event notification sent when you select the notification button.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category>))]
public sealed record Category : OpenStringEnum<Category>
{
    private Category(string value) : base(value)
    {
    }

    public static readonly Category SaleWakeUp = new("SaleWakeUp");

    public static readonly Category KeyPressed = new("KeyPressed");

    public TResult Match<TResult>(Func<TResult> onSaleWakeUp,
        Func<TResult> onKeyPressed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SaleWakeUp => onSaleWakeUp(),
            _ when this == KeyPressed => onKeyPressed(),
            _ => otherwise(Value)
        };

    public void Match(Action onSaleWakeUp, Action onKeyPressed, Action<string> otherwise)
    {
        if (this == SaleWakeUp) onSaleWakeUp();
        else if (this == KeyPressed) onKeyPressed();
        else otherwise(Value);
    }
}
