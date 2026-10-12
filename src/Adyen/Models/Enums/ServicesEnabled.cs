using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ServicesEnabled>))]
public sealed record ServicesEnabled : OpenStringEnum<ServicesEnabled>
{
    private ServicesEnabled(string value) : base(value)
    {
    }

    public static readonly ServicesEnabled CardAcquisition = new("CardAcquisition");

    public static readonly ServicesEnabled Payment = new("Payment");

    public static readonly ServicesEnabled Loyalty = new("Loyalty");

    public TResult Match<TResult>(Func<TResult> onCardAcquisition,
        Func<TResult> onPayment,
        Func<TResult> onLoyalty,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CardAcquisition => onCardAcquisition(),
            _ when this == Payment => onPayment(),
            _ when this == Loyalty => onLoyalty(),
            _ => otherwise(Value)
        };

    public void Match(Action onCardAcquisition, Action onPayment, Action onLoyalty, Action<string> otherwise)
    {
        if (this == CardAcquisition) onCardAcquisition();
        else if (this == Payment) onPayment();
        else if (this == Loyalty) onLoyalty();
        else otherwise(Value);
    }
}
