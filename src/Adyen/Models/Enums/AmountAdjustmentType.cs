using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of markup that is applied to an authorised payment.
/// <para>
/// Possible values: <b>exchange</b>, <b>forexMarkup</b>, <b>authHoldReserve</b>, <b>atmMarkup</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AmountAdjustmentType>))]
public sealed record AmountAdjustmentType : OpenStringEnum<AmountAdjustmentType>
{
    private AmountAdjustmentType(string value) : base(value)
    {
    }

    public static readonly AmountAdjustmentType AtmMarkup = new("atmMarkup");

    public static readonly AmountAdjustmentType AuthHoldReserve = new("authHoldReserve");

    public static readonly AmountAdjustmentType Exchange = new("exchange");

    public static readonly AmountAdjustmentType ForexMarkup = new("forexMarkup");

    public TResult Match<TResult>(Func<TResult> onAtmMarkup,
        Func<TResult> onAuthHoldReserve,
        Func<TResult> onExchange,
        Func<TResult> onForexMarkup,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AtmMarkup => onAtmMarkup(),
            _ when this == AuthHoldReserve => onAuthHoldReserve(),
            _ when this == Exchange => onExchange(),
            _ when this == ForexMarkup => onForexMarkup(),
            _ => otherwise(Value)
        };

    public void Match(Action onAtmMarkup,
        Action onAuthHoldReserve,
        Action onExchange,
        Action onForexMarkup,
        Action<string> otherwise)
    {
        if (this == AtmMarkup) onAtmMarkup();
        else if (this == AuthHoldReserve) onAuthHoldReserve();
        else if (this == Exchange) onExchange();
        else if (this == ForexMarkup) onForexMarkup();
        else otherwise(Value);
    }
}
