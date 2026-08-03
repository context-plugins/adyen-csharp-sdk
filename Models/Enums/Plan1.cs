using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Plan1>))]
public sealed record Plan1 : StringEnum<Plan1>
{
    private Plan1(string value) : base(value)
    {
    }

    public static readonly Plan1 Bonus = new("bonus");

    public static readonly Plan1 BuynowPaylater = new("buynow_paylater");

    public static readonly Plan1 InteresRefundPrctg = new("interes_refund_prctg");

    public static readonly Plan1 InterestBonus = new("interest_bonus");

    public static readonly Plan1 NointeresRefundPrctg = new("nointeres_refund_prctg");

    public static readonly Plan1 NointerestBonus = new("nointerest_bonus");

    public static readonly Plan1 RefundPrctg = new("refund_prctg");

    public static readonly Plan1 Regular = new("regular");

    public static readonly Plan1 Revolving = new("revolving");

    public static readonly Plan1 WithInterest = new("with_interest");

    public static Plan1 FromValue(string value) => FromValueCore(value);
}
