using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The method of handling the chargeback.
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>., Specifies how and from which balance account(s) to deduct the chargeback amount.
/// </para>
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>., Specifies how and from which balance account(s) to deduct the refund amount.
/// </para>
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Behavior>))]
public sealed record Behavior : OpenStringEnum<Behavior>
{
    private Behavior(string value) : base(value)
    {
    }

    public static readonly Behavior DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static readonly Behavior DeductAccordingToSplitRatio = new("deductAccordingToSplitRatio");

    public static readonly Behavior DeductFromLiableAccount = new("deductFromLiableAccount");

    public TResult Match<TResult>(Func<TResult> onDeductFromOneBalanceAccount,
        Func<TResult> onDeductAccordingToSplitRatio,
        Func<TResult> onDeductFromLiableAccount,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DeductFromOneBalanceAccount => onDeductFromOneBalanceAccount(),
            _ when this == DeductAccordingToSplitRatio => onDeductAccordingToSplitRatio(),
            _ when this == DeductFromLiableAccount => onDeductFromLiableAccount(),
            _ => otherwise(Value)
        };

    public void Match(Action onDeductFromOneBalanceAccount,
        Action onDeductAccordingToSplitRatio,
        Action onDeductFromLiableAccount,
        Action<string> otherwise)
    {
        if (this == DeductFromOneBalanceAccount) onDeductFromOneBalanceAccount();
        else if (this == DeductAccordingToSplitRatio) onDeductAccordingToSplitRatio();
        else if (this == DeductFromLiableAccount) onDeductFromLiableAccount();
        else otherwise(Value);
    }
}
