using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Sets the allowed payment instrument for Pay at table transactions.  Can be: <b>cash</b> or <b>card</b>. If not set, the terminal presents both options.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentInstrument>))]
public sealed record PaymentInstrument : OpenStringEnum<PaymentInstrument>
{
    private PaymentInstrument(string value) : base(value)
    {
    }

    public static readonly PaymentInstrument Cash = new("Cash");

    public static readonly PaymentInstrument Card = new("Card");

    public TResult Match<TResult>(Func<TResult> onCash, Func<TResult> onCard, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cash => onCash(),
            _ when this == Card => onCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onCash, Action onCard, Action<string> otherwise)
    {
        if (this == Cash) onCash();
        else if (this == Card) onCard();
        else otherwise(Value);
    }
}
