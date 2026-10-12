using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The installment plan, used for <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments#make-a-payment-japan">card installments in Japan</see>.
/// and <see href="https://docs.adyen.com/payment-methods/cards/credit-card-installments/#getting-paid-mexico">Mexico</see>.
/// By default, this is set to <b>regular</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Plan>))]
public sealed record Plan : OpenStringEnum<Plan>
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

    public TResult Match<TResult>(Func<TResult> onBonus,
        Func<TResult> onBuynowPaylater,
        Func<TResult> onInteresRefundPrctg,
        Func<TResult> onInterestBonus,
        Func<TResult> onNointeresRefundPrctg,
        Func<TResult> onNointerestBonus,
        Func<TResult> onRefundPrctg,
        Func<TResult> onRegular,
        Func<TResult> onRevolving,
        Func<TResult> onWithInterest,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bonus => onBonus(),
            _ when this == BuynowPaylater => onBuynowPaylater(),
            _ when this == InteresRefundPrctg => onInteresRefundPrctg(),
            _ when this == InterestBonus => onInterestBonus(),
            _ when this == NointeresRefundPrctg => onNointeresRefundPrctg(),
            _ when this == NointerestBonus => onNointerestBonus(),
            _ when this == RefundPrctg => onRefundPrctg(),
            _ when this == Regular => onRegular(),
            _ when this == Revolving => onRevolving(),
            _ when this == WithInterest => onWithInterest(),
            _ => otherwise(Value)
        };

    public void Match(Action onBonus,
        Action onBuynowPaylater,
        Action onInteresRefundPrctg,
        Action onInterestBonus,
        Action onNointeresRefundPrctg,
        Action onNointerestBonus,
        Action onRefundPrctg,
        Action onRegular,
        Action onRevolving,
        Action onWithInterest,
        Action<string> otherwise)
    {
        if (this == Bonus) onBonus();
        else if (this == BuynowPaylater) onBuynowPaylater();
        else if (this == InteresRefundPrctg) onInteresRefundPrctg();
        else if (this == InterestBonus) onInterestBonus();
        else if (this == NointeresRefundPrctg) onNointeresRefundPrctg();
        else if (this == NointerestBonus) onNointerestBonus();
        else if (this == RefundPrctg) onRefundPrctg();
        else if (this == Regular) onRegular();
        else if (this == Revolving) onRevolving();
        else if (this == WithInterest) onWithInterest();
        else otherwise(Value);
    }
}
