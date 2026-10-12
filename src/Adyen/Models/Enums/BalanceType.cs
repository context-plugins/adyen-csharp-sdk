using System;
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
public sealed record BalanceType : OpenStringEnum<BalanceType>
{
    private BalanceType(string value) : base(value)
    {
    }

    public static readonly BalanceType Balance = new("balance");

    public static readonly BalanceType Available = new("available");

    public static readonly BalanceType Pending = new("pending");

    public static readonly BalanceType Reserved = new("reserved");

    public TResult Match<TResult>(Func<TResult> onBalance,
        Func<TResult> onAvailable,
        Func<TResult> onPending,
        Func<TResult> onReserved,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Balance => onBalance(),
            _ when this == Available => onAvailable(),
            _ when this == Pending => onPending(),
            _ when this == Reserved => onReserved(),
            _ => otherwise(Value)
        };

    public void Match(Action onBalance,
        Action onAvailable,
        Action onPending,
        Action onReserved,
        Action<string> otherwise)
    {
        if (this == Balance) onBalance();
        else if (this == Available) onAvailable();
        else if (this == Pending) onPending();
        else if (this == Reserved) onReserved();
        else otherwise(Value);
    }
}
