using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Define when you want to get notified about a balance change. Possible values:
/// <list type="bullet">
///   <item><description><b>greaterThan</b>: the balance in the account(s) exceeds the specified <c>value</c>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>greaterThanOrEqual</b>: the balance in the account(s) reaches or exceeds the specified <c>value</c>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>lessThan</b>: the balance in the account(s) drops below the specified <c>value</c>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>lessThanOrEqual</b>: the balance in the account(s) reaches to drops below the specified <c>value</c>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConditionType>))]
public sealed record ConditionType : OpenStringEnum<ConditionType>
{
    private ConditionType(string value) : base(value)
    {
    }

    public static readonly ConditionType GreaterThan = new("greaterThan");

    public static readonly ConditionType GreaterThanOrEqual = new("greaterThanOrEqual");

    public static readonly ConditionType LessThan = new("lessThan");

    public static readonly ConditionType LessThanOrEqual = new("lessThanOrEqual");

    public TResult Match<TResult>(Func<TResult> onGreaterThan,
        Func<TResult> onGreaterThanOrEqual,
        Func<TResult> onLessThan,
        Func<TResult> onLessThanOrEqual,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GreaterThan => onGreaterThan(),
            _ when this == GreaterThanOrEqual => onGreaterThanOrEqual(),
            _ when this == LessThan => onLessThan(),
            _ when this == LessThanOrEqual => onLessThanOrEqual(),
            _ => otherwise(Value)
        };

    public void Match(Action onGreaterThan,
        Action onGreaterThanOrEqual,
        Action onLessThan,
        Action onLessThanOrEqual,
        Action<string> otherwise)
    {
        if (this == GreaterThan) onGreaterThan();
        else if (this == GreaterThanOrEqual) onGreaterThanOrEqual();
        else if (this == LessThan) onLessThan();
        else if (this == LessThanOrEqual) onLessThanOrEqual();
        else otherwise(Value);
    }
}
