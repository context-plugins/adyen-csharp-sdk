using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The <see href="https://docs.adyen.com/issuing/transaction-rules#time-intervals">type of interval</see> during which the rule conditions and limits apply, and how often counters are reset.
/// <para>
/// Possible values:
///   * <b>perTransaction</b>: conditions are evaluated and the counters are reset for every transaction.
///  * <b>daily</b>: the counters are reset daily at 00:00:00 CET.
///  * <b>weekly</b>: the counters are reset every Monday at 00:00:00 CET.
///  * <b>monthly</b>: the counters reset every first day of the month at 00:00:00 CET.
///  * <b>lifetime</b>: conditions are applied to the lifetime of the payment instrument.
///  * <b>rolling</b>: conditions are applied and the counters are reset based on a <c>duration</c>. If the reset date and time are not provided, Adyen applies the default reset time similar to fixed intervals. For example, if the duration is every two weeks, the counter resets every third Monday at 00:00:00 CET.
///  * <b>sliding</b>: conditions are applied and the counters are reset based on the current time and a <c>duration</c> that you specify.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type131>))]
public sealed record Type131 : OpenStringEnum<Type131>
{
    private Type131(string value) : base(value)
    {
    }

    public static readonly Type131 Daily = new("daily");

    public static readonly Type131 Lifetime = new("lifetime");

    public static readonly Type131 Monthly = new("monthly");

    public static readonly Type131 PerTransaction = new("perTransaction");

    public static readonly Type131 Rolling = new("rolling");

    public static readonly Type131 Sliding = new("sliding");

    public static readonly Type131 Weekly = new("weekly");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onLifetime,
        Func<TResult> onMonthly,
        Func<TResult> onPerTransaction,
        Func<TResult> onRolling,
        Func<TResult> onSliding,
        Func<TResult> onWeekly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Lifetime => onLifetime(),
            _ when this == Monthly => onMonthly(),
            _ when this == PerTransaction => onPerTransaction(),
            _ when this == Rolling => onRolling(),
            _ when this == Sliding => onSliding(),
            _ when this == Weekly => onWeekly(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily,
        Action onLifetime,
        Action onMonthly,
        Action onPerTransaction,
        Action onRolling,
        Action onSliding,
        Action onWeekly,
        Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Lifetime) onLifetime();
        else if (this == Monthly) onMonthly();
        else if (this == PerTransaction) onPerTransaction();
        else if (this == Rolling) onRolling();
        else if (this == Sliding) onSliding();
        else if (this == Weekly) onWeekly();
        else otherwise(Value);
    }
}
