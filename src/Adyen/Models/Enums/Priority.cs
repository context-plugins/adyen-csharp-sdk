using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Determines how long it takes for the funds to reach the bank account. Adyen pays out based on the <see href="https://docs.adyen.com/account/getting-paid#payout-frequency">payout frequency</see>. Depending on the currencies and banks involved in transferring the money, it may take up to three days for the payout funds to arrive in the bank account.
/// <para>
///  Possible values:
/// * <b>first</b>: same day.
/// * <b>urgent</b>: the next day.
/// * <b>normal</b>: between 1 and 3 days.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Priority>))]
public sealed record Priority : OpenStringEnum<Priority>
{
    private Priority(string value) : base(value)
    {
    }

    public static readonly Priority First = new("first");

    public static readonly Priority Normal = new("normal");

    public static readonly Priority Urgent = new("urgent");

    public TResult Match<TResult>(Func<TResult> onFirst,
        Func<TResult> onNormal,
        Func<TResult> onUrgent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == First => onFirst(),
            _ when this == Normal => onNormal(),
            _ when this == Urgent => onUrgent(),
            _ => otherwise(Value)
        };

    public void Match(Action onFirst, Action onNormal, Action onUrgent, Action<string> otherwise)
    {
        if (this == First) onFirst();
        else if (this == Normal) onNormal();
        else if (this == Urgent) onUrgent();
        else otherwise(Value);
    }
}
