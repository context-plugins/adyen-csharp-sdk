using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The schedule type.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>cron</b>: push out funds based on a <c>cronExpression</c>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>daily</b>: push out funds daily at 07:00 AM CET.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>weekly</b>: push out funds every Monday at 07:00 AM CET.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>monthly</b>: push out funds every first of the month at 07:00 AM CET.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>balance</b>: execute the sweep instantly if the <c>triggerAmount</c> is reached.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type62>))]
public sealed record Type62 : OpenStringEnum<Type62>
{
    private Type62(string value) : base(value)
    {
    }

    public static readonly Type62 Daily = new("daily");

    public static readonly Type62 Weekly = new("weekly");

    public static readonly Type62 Monthly = new("monthly");

    public static readonly Type62 Balance = new("balance");

    public static readonly Type62 Cron = new("cron");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onMonthly,
        Func<TResult> onBalance,
        Func<TResult> onCron,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Balance => onBalance(),
            _ when this == Cron => onCron(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily,
        Action onWeekly,
        Action onMonthly,
        Action onBalance,
        Action onCron,
        Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else if (this == Balance) onBalance();
        else if (this == Cron) onCron();
        else otherwise(Value);
    }
}
