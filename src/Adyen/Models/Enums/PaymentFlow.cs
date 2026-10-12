using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The sales channel used for the payment., The sales channel. Possible values: <b>Ecommerce</b>, <b>POS</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentFlow>))]
public sealed record PaymentFlow : OpenStringEnum<PaymentFlow>
{
    private PaymentFlow(string value) : base(value)
    {
    }

    public static readonly PaymentFlow Ecommerce = new("Ecommerce");

    public static readonly PaymentFlow Pos = new("POS");

    public TResult Match<TResult>(Func<TResult> onEcommerce, Func<TResult> onPos, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ecommerce => onEcommerce(),
            _ when this == Pos => onPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onEcommerce, Action onPos, Action<string> otherwise)
    {
        if (this == Ecommerce) onEcommerce();
        else if (this == Pos) onPos();
        else otherwise(Value);
    }
}
