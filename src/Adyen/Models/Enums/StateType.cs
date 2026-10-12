using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The state to be updated.
/// &gt;Permitted values are: <c>Processing</c>, <c>Payout</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StateType>))]
public sealed record StateType : OpenStringEnum<StateType>
{
    private StateType(string value) : base(value)
    {
    }

    public static readonly StateType LimitedPayout = new("LimitedPayout");

    public static readonly StateType LimitedProcessing = new("LimitedProcessing");

    public static readonly StateType LimitlessPayout = new("LimitlessPayout");

    public static readonly StateType LimitlessProcessing = new("LimitlessProcessing");

    public static readonly StateType Payout = new("Payout");

    public static readonly StateType Processing = new("Processing");

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
