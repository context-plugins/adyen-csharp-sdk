using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value4>))]
public sealed record Value4 : StringEnum<Value4>
{
    private Value4(string value) : base(value)
    {
    }

    public static readonly Value4 AtmWithdraw = new("atmWithdraw");

    public static readonly Value4 BalanceInquiry = new("balanceInquiry");

    public static readonly Value4 Ecommerce = new("ecommerce");

    public static readonly Value4 Moto = new("moto");

    public static readonly Value4 Pos = new("pos");

    public static readonly Value4 Recurring = new("recurring");

    public static readonly Value4 Token = new("token");

    public static readonly Value4 Unknown = new("unknown");

    public static Value4 FromValue(string value) => FromValueCore(value);
}
