using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The rule to specify the period, within which the recurring debit can happen, relative to the mandate recurring date.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>on</b>: On a specific date.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>before</b>:  Before and on a specific date.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>after</b>: On and after a specific date.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BillingAttemptsRule>))]
public sealed record BillingAttemptsRule : OpenStringEnum<BillingAttemptsRule>
{
    private BillingAttemptsRule(string value) : base(value)
    {
    }

    public static readonly BillingAttemptsRule On = new("on");

    public static readonly BillingAttemptsRule Before = new("before");

    public static readonly BillingAttemptsRule After = new("after");

    public TResult Match<TResult>(Func<TResult> onOn,
        Func<TResult> onBefore,
        Func<TResult> onAfter,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == On => onOn(),
            _ when this == Before => onBefore(),
            _ when this == After => onAfter(),
            _ => otherwise(Value)
        };

    public void Match(Action onOn, Action onBefore, Action onAfter, Action<string> otherwise)
    {
        if (this == On) onOn();
        else if (this == Before) onBefore();
        else if (this == After) onAfter();
        else otherwise(Value);
    }
}
