using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the reason for creating the rule.
/// <para>
/// Possible values:
/// * <b>fraud</b>: the rule is created to regulate fraudulent activity.
/// * <b>policy</b>: the rule is created to ensure that the transaction adheres to your business' policies. For example, if your business has policies about the Merchant Category Codes (MCCs) allowed on a transaction, you can create a rule to block transactions that have specific MCCs.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Purpose>))]
public sealed record Purpose : OpenStringEnum<Purpose>
{
    private Purpose(string value) : base(value)
    {
    }

    public static readonly Purpose Compliance = new("compliance");

    public static readonly Purpose Fraud = new("fraud");

    public static readonly Purpose InternalPolicy = new("internalPolicy");

    public static readonly Purpose Policy = new("policy");

    public static readonly Purpose System = new("system");

    public TResult Match<TResult>(Func<TResult> onCompliance,
        Func<TResult> onFraud,
        Func<TResult> onInternalPolicy,
        Func<TResult> onPolicy,
        Func<TResult> onSystem,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Compliance => onCompliance(),
            _ when this == Fraud => onFraud(),
            _ when this == InternalPolicy => onInternalPolicy(),
            _ when this == Policy => onPolicy(),
            _ when this == System => onSystem(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompliance,
        Action onFraud,
        Action onInternalPolicy,
        Action onPolicy,
        Action onSystem,
        Action<string> otherwise)
    {
        if (this == Compliance) onCompliance();
        else if (this == Fraud) onFraud();
        else if (this == InternalPolicy) onInternalPolicy();
        else if (this == Policy) onPolicy();
        else if (this == System) onSystem();
        else otherwise(Value);
    }
}
