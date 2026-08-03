using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The resource for which you want to receive notifications. Possible values:
/// <list type="bullet">
///   <item><description><b>balancePlatform</b>: receive notifications about balance changes in your entire balance platform.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>accountHolder</b>: receive notifications about balance changes of a specific user.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>balanceAccount</b>: receive notifications about balance changes in a specific balance account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type18>))]
public sealed record Type18 : StringEnum<Type18>
{
    private Type18(string value) : base(value)
    {
    }

    public static readonly Type18 BalanceAccount = new("balanceAccount");

    public static readonly Type18 AccountHolder = new("accountHolder");

    public static readonly Type18 BalancePlatform = new("balancePlatform");

    public static Type18 FromValue(string value) => FromValueCore(value);
}
