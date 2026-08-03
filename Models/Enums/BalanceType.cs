using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Define the type of balance about which you want to get notified. Possible values:
/// <list type="bullet">
///   <item><description><b>available</b>: the balance available for use.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>balance</b>: the sum of transactions that have already been settled.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>pending</b>: the sum of transactions that will be settled in the future.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>reserved</b>: the balance currently held in reserve.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BalanceType>))]
public sealed record BalanceType : StringEnum<BalanceType>
{
    private BalanceType(string value) : base(value)
    {
    }

    public static readonly BalanceType Balance = new("balance");

    public static readonly BalanceType Available = new("available");

    public static readonly BalanceType Pending = new("pending");

    public static readonly BalanceType Reserved = new("reserved");

    public static BalanceType FromValue(string value) => FromValueCore(value);
}
