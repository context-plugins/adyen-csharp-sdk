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
public sealed record ConditionType : StringEnum<ConditionType>
{
    private ConditionType(string value) : base(value)
    {
    }

    public static readonly ConditionType GreaterThan = new("greaterThan");

    public static readonly ConditionType GreaterThanOrEqual = new("greaterThanOrEqual");

    public static readonly ConditionType LessThan = new("lessThan");

    public static readonly ConditionType LessThanOrEqual = new("lessThanOrEqual");

    public static ConditionType FromValue(string value) => FromValueCore(value);
}
