using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The installment plan, used for <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments#make-a-payment-japan">card installments in Japan</see>.
/// and <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments/#getting-paid-mexico">Mexico</see>.
/// By default, this is set to <b>regular</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Plan>))]
public sealed record Plan : StringEnum<Plan>
{
    private Plan(string value) : base(value)
    {
    }

    public static readonly Plan Bonus = new("bonus");

    public static readonly Plan BuynowPaylater = new("buynow_paylater");

    public static readonly Plan InteresRefundPrctg = new("interes_refund_prctg");

    public static readonly Plan InterestBonus = new("interest_bonus");

    public static readonly Plan NointeresRefundPrctg = new("nointeres_refund_prctg");

    public static readonly Plan NointerestBonus = new("nointerest_bonus");

    public static readonly Plan RefundPrctg = new("refund_prctg");

    public static readonly Plan Regular = new("regular");

    public static readonly Plan Revolving = new("revolving");

    public static readonly Plan WithInterest = new("with_interest");

    public static Plan FromValue(string value) => FromValueCore(value);
}
