using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transaction. Possible values:
/// * <b>splitPayment</b>: for payments
/// * <b>splitRefund</b>: for refunds
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RateType2>))]
public sealed record RateType2 : StringEnum<RateType2>
{
    private RateType2(string value) : base(value)
    {
    }

    public static readonly RateType2 SplitPayment = new("splitPayment");

    public static readonly RateType2 BalanceConversion = new("balanceConversion");

    public static readonly RateType2 Transfer = new("transfer");

    public static readonly RateType2 SplitRefund = new("splitRefund");

    public static RateType2 FromValue(string value) => FromValueCore(value);
}
