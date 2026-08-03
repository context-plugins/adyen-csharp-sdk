using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RateType1>))]
public sealed record RateType1 : StringEnum<RateType1>
{
    private RateType1(string value) : base(value)
    {
    }

    public static readonly RateType1 SplitPayment = new("splitPayment");

    public static readonly RateType1 BalanceConversion = new("balanceConversion");

    public static readonly RateType1 Transfer = new("transfer");

    public static readonly RateType1 SplitRefund = new("splitRefund");

    public static RateType1 FromValue(string value) => FromValueCore(value);
}
