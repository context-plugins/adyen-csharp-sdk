using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The state required for the account holder.
/// &gt; Permitted values: <c>Processing</c>, <c>Payout</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountStateType>))]
public sealed record AccountStateType : OpenStringEnum<AccountStateType>
{
    private AccountStateType(string value) : base(value)
    {
    }

    public static readonly AccountStateType LimitedPayout = new("LimitedPayout");

    public static readonly AccountStateType LimitedProcessing = new("LimitedProcessing");

    public static readonly AccountStateType LimitlessPayout = new("LimitlessPayout");

    public static readonly AccountStateType LimitlessProcessing = new("LimitlessProcessing");

    public static readonly AccountStateType Payout = new("Payout");

    public static readonly AccountStateType Processing = new("Processing");

    public TResult Match<TResult>(Func<TResult> onLimitedPayout,
        Func<TResult> onLimitedProcessing,
        Func<TResult> onLimitlessPayout,
        Func<TResult> onLimitlessProcessing,
        Func<TResult> onPayout,
        Func<TResult> onProcessing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LimitedPayout => onLimitedPayout(),
            _ when this == LimitedProcessing => onLimitedProcessing(),
            _ when this == LimitlessPayout => onLimitlessPayout(),
            _ when this == LimitlessProcessing => onLimitlessProcessing(),
            _ when this == Payout => onPayout(),
            _ when this == Processing => onProcessing(),
            _ => otherwise(Value)
        };

    public void Match(Action onLimitedPayout,
        Action onLimitedProcessing,
        Action onLimitlessPayout,
        Action onLimitlessProcessing,
        Action onPayout,
        Action onProcessing,
        Action<string> otherwise)
    {
        if (this == LimitedPayout) onLimitedPayout();
        else if (this == LimitedProcessing) onLimitedProcessing();
        else if (this == LimitlessPayout) onLimitlessPayout();
        else if (this == LimitlessProcessing) onLimitlessProcessing();
        else if (this == Payout) onPayout();
        else if (this == Processing) onProcessing();
        else otherwise(Value);
    }
}
