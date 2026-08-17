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
[JsonConverter(typeof(StringEnumConverter<Type181>))]
public sealed record Type181 : StringEnum<Type181>
{
    private Type181(string value) : base(value)
    {
    }

    public static readonly Type181 BalanceAccount = new("balanceAccount");

    public static readonly Type181 AccountHolder = new("accountHolder");

    public static readonly Type181 BalancePlatform = new("balancePlatform");

    public static Type181 FromValue(string value) => FromValueCore(value);
}
