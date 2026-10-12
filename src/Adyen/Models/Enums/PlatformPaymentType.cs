using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the nature of the transfer. This parameter helps categorize transfers so you can reconcile transactions at a later time, using the Balance Platform Accounting Report for <see href="https://docs.adyen.com/marketplaces/reports-and-fees/balance-platform-accounting-report/">marketplaces</see> or <see href="https://docs.adyen.com/platforms/reports-and-fees/balance-platform-accounting-report/">platforms</see>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>AcquiringFees</b>: The acquiring fee (the aggregated amount of interchange and scheme fee) incurred on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>AdyenCommission</b>: The transaction fee due to Adyen under <see href="https://www.adyen.com/knowledge-hub/guides/payments-training-guide/get-the-best-from-your-card-processing">blended rates</see>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>AdyenFees</b>: All transaction fees due to Adyen. This is the aggregated amount of Adyen's commission and markup.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>AdyenMarkup</b>: The transaction fee due to Adyen under <see href="https://www.adyen.com/pricing">Interchange++ pricing</see>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>BalanceAccount</b>: The amount booked to your user after the deduction of the relevant fees.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Commission</b>: Your platform's or marketplace's commission on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>DCCPlatformCommission</b>: <b>deprecated</b> The Dynamic Currency Conversion (DCC) fee on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>DCCMarkup</b>: The Dynamic Currency Conversion (DCC) fee on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Interchange</b>: The interchange fee (fee paid to the issuer) incurred on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>PaymentFee</b>: The aggregated amount of all transaction fees.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Remainder</b>: The leftover amount after currency conversion.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>SchemeFee</b>: The scheme fee incurred on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Surcharge</b>: The surcharge paid by the customer on a transaction.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>Tip</b>: The tip paid by the customer.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>TopUp</b>: An incoming transfer to top up your user's balance account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>VAT</b>: The value-added tax charged on the payment.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlatformPaymentType>))]
public sealed record PlatformPaymentType : OpenStringEnum<PlatformPaymentType>
{
    private PlatformPaymentType(string value) : base(value)
    {
    }

    public static readonly PlatformPaymentType AcquiringFees = new("AcquiringFees");

    public static readonly PlatformPaymentType AdyenCommission = new("AdyenCommission");

    public static readonly PlatformPaymentType AdyenFees = new("AdyenFees");

    public static readonly PlatformPaymentType AdyenMarkup = new("AdyenMarkup");

    public static readonly PlatformPaymentType BalanceAccount = new("BalanceAccount");

    public static readonly PlatformPaymentType ChargebackRemainder = new("ChargebackRemainder");

    public static readonly PlatformPaymentType Commission = new("Commission");

    public static readonly PlatformPaymentType DccMarkup = new("DCCMarkup");

    public static readonly PlatformPaymentType DccPlatformCommission = new("DCCPlatformCommission");

    public static readonly PlatformPaymentType Default = new("Default");

    public static readonly PlatformPaymentType Interchange = new("Interchange");

    public static readonly PlatformPaymentType PaymentFee = new("PaymentFee");

    public static readonly PlatformPaymentType Remainder = new("Remainder");

    public static readonly PlatformPaymentType SchemeFee = new("SchemeFee");

    public static readonly PlatformPaymentType Surcharge = new("Surcharge");

    public static readonly PlatformPaymentType Tip = new("Tip");

    public static readonly PlatformPaymentType TopUp = new("TopUp");

    public static readonly PlatformPaymentType Vat = new("VAT");

    public TResult Match<TResult>(Func<TResult> onAcquiringFees,
        Func<TResult> onAdyenCommission,
        Func<TResult> onAdyenFees,
        Func<TResult> onAdyenMarkup,
        Func<TResult> onBalanceAccount,
        Func<TResult> onChargebackRemainder,
        Func<TResult> onCommission,
        Func<TResult> onDccMarkup,
        Func<TResult> onDccPlatformCommission,
        Func<TResult> onDefault,
        Func<TResult> onInterchange,
        Func<TResult> onPaymentFee,
        Func<TResult> onRemainder,
        Func<TResult> onSchemeFee,
        Func<TResult> onSurcharge,
        Func<TResult> onTip,
        Func<TResult> onTopUp,
        Func<TResult> onVat,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AcquiringFees => onAcquiringFees(),
            _ when this == AdyenCommission => onAdyenCommission(),
            _ when this == AdyenFees => onAdyenFees(),
            _ when this == AdyenMarkup => onAdyenMarkup(),
            _ when this == BalanceAccount => onBalanceAccount(),
            _ when this == ChargebackRemainder => onChargebackRemainder(),
            _ when this == Commission => onCommission(),
            _ when this == DccMarkup => onDccMarkup(),
            _ when this == DccPlatformCommission => onDccPlatformCommission(),
            _ when this == Default => onDefault(),
            _ when this == Interchange => onInterchange(),
            _ when this == PaymentFee => onPaymentFee(),
            _ when this == Remainder => onRemainder(),
            _ when this == SchemeFee => onSchemeFee(),
            _ when this == Surcharge => onSurcharge(),
            _ when this == Tip => onTip(),
            _ when this == TopUp => onTopUp(),
            _ when this == Vat => onVat(),
            _ => otherwise(Value)
        };

    public void Match(Action onAcquiringFees,
        Action onAdyenCommission,
        Action onAdyenFees,
        Action onAdyenMarkup,
        Action onBalanceAccount,
        Action onChargebackRemainder,
        Action onCommission,
        Action onDccMarkup,
        Action onDccPlatformCommission,
        Action onDefault,
        Action onInterchange,
        Action onPaymentFee,
        Action onRemainder,
        Action onSchemeFee,
        Action onSurcharge,
        Action onTip,
        Action onTopUp,
        Action onVat,
        Action<string> otherwise)
    {
        if (this == AcquiringFees) onAcquiringFees();
        else if (this == AdyenCommission) onAdyenCommission();
        else if (this == AdyenFees) onAdyenFees();
        else if (this == AdyenMarkup) onAdyenMarkup();
        else if (this == BalanceAccount) onBalanceAccount();
        else if (this == ChargebackRemainder) onChargebackRemainder();
        else if (this == Commission) onCommission();
        else if (this == DccMarkup) onDccMarkup();
        else if (this == DccPlatformCommission) onDccPlatformCommission();
        else if (this == Default) onDefault();
        else if (this == Interchange) onInterchange();
        else if (this == PaymentFee) onPaymentFee();
        else if (this == Remainder) onRemainder();
        else if (this == SchemeFee) onSchemeFee();
        else if (this == Surcharge) onSurcharge();
        else if (this == Tip) onTip();
        else if (this == TopUp) onTopUp();
        else if (this == Vat) onVat();
        else otherwise(Value);
    }
}
