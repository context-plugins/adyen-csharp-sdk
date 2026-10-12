using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of recurring contract to be used.
/// Possible values:
/// * <c>ONECLICK</c> – Payment details can be used to initiate a one-click payment, where the shopper enters the <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid">card security code (CVC/CVV)</see>.
/// * <c>RECURRING</c> – Payment details can be used without the card security code to initiate <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-not-present-cnp">card-not-present transactions</see>.
/// * <c>ONECLICK,RECURRING</c> – Payment details can be used regardless of whether the shopper is on your site or not.
/// * <c>PAYOUT</c> – Payment details can be used to <see href="https://docs.adyen.com/online-payments/online-payouts">make a payout</see>.
/// * <c>EXTERNAL</c> - Use this when you store payment details and send the raw card number or network token directly in your API request.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Contract>))]
public sealed record Contract : OpenStringEnum<Contract>
{
    private Contract(string value) : base(value)
    {
    }

    public static readonly Contract Oneclick = new("ONECLICK");

    public static readonly Contract OneclickRecurring = new("ONECLICK,RECURRING");

    public static readonly Contract Recurring = new("RECURRING");

    public static readonly Contract Payout = new("PAYOUT");

    public static readonly Contract External = new("EXTERNAL");

    public TResult Match<TResult>(Func<TResult> onOneclick,
        Func<TResult> onOneclickRecurring,
        Func<TResult> onRecurring,
        Func<TResult> onPayout,
        Func<TResult> onExternal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Oneclick => onOneclick(),
            _ when this == OneclickRecurring => onOneclickRecurring(),
            _ when this == Recurring => onRecurring(),
            _ when this == Payout => onPayout(),
            _ when this == External => onExternal(),
            _ => otherwise(Value)
        };

    public void Match(Action onOneclick,
        Action onOneclickRecurring,
        Action onRecurring,
        Action onPayout,
        Action onExternal,
        Action<string> otherwise)
    {
        if (this == Oneclick) onOneclick();
        else if (this == OneclickRecurring) onOneclickRecurring();
        else if (this == Recurring) onRecurring();
        else if (this == Payout) onPayout();
        else if (this == External) onExternal();
        else otherwise(Value);
    }
}
