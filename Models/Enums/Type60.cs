using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The part of the payment you want to book to the specified <c>account</c>.
/// <para>
/// Possible values for the <see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see>:
/// * <b>BalanceAccount</b>: books part of the payment (specified in <c>amount</c>) to the specified <c>account</c>.
/// * Transaction fees types that you can book to the specified <c>account</c>:
///    * <b>AcquiringFees</b>: the aggregated amount of the interchange and scheme fees.
///    * <b>PaymentFee</b>: the aggregated amount of all transaction fees.
///    * <b>AdyenFees</b>: the aggregated amount of Adyen's commission and markup fees.
///    * <b>AdyenCommission</b>: the transaction fees due to Adyen under <see href="https://www.adyen.com/knowledge-hub/interchange-fees-explained">blended rates</see>.
///    * <b>AdyenMarkup</b>: the transaction fees due to Adyen under <see href="https://www.adyen.com/knowledge-hub/interchange-fees-explained">Interchange ++ pricing</see>.
///    * <b>Interchange</b>: the fees paid to the issuer for each payment made with the card network.
///    * <b>SchemeFee</b>: the fees paid to the card scheme for using their network.
/// * <b>Commission</b>: your platform's commission on the payment (specified in <c>amount</c>), booked to your liable balance account.
/// * <b>Remainder</b>: the amount left over after a currency conversion, booked to the specified <c>account</c>.
/// * <b>TopUp</b>: allows you and your users to top up balance accounts using direct debit, card payments, or other payment methods.
/// * <b>VAT</b>: the value-added tax charged on the payment, booked to your platforms liable balance account.
/// * <b>Commission</b>: your platform's commission (specified in <c>amount</c>) on the payment, booked to your liable balance account.
/// * <b>Default</b>: in very specific use cases, allows you to book the specified <c>amount</c> to the specified <c>account</c>. For more information, contact Adyen support.
/// </para>
/// <para>
/// Possible values for the <see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>: <b>Commission</b>, <b>Default</b>, <b>Marketplace</b>, <b>PaymentFee</b>, <b>VAT</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type60>))]
public sealed record Type60 : StringEnum<Type60>
{
    private Type60(string value) : base(value)
    {
    }

    public static readonly Type60 AcquiringFees = new("AcquiringFees");

    public static readonly Type60 AdyenCommission = new("AdyenCommission");

    public static readonly Type60 AdyenFees = new("AdyenFees");

    public static readonly Type60 AdyenMarkup = new("AdyenMarkup");

    public static readonly Type60 BalanceAccount = new("BalanceAccount");

    public static readonly Type60 Commission = new("Commission");

    public static readonly Type60 Default = new("Default");

    public static readonly Type60 Interchange = new("Interchange");

    public static readonly Type60 MarketPlace = new("MarketPlace");

    public static readonly Type60 PaymentFee = new("PaymentFee");

    public static readonly Type60 Remainder = new("Remainder");

    public static readonly Type60 SchemeFee = new("SchemeFee");

    public static readonly Type60 Surcharge = new("Surcharge");

    public static readonly Type60 Tip = new("Tip");

    public static readonly Type60 Vat = new("VAT");

    public static Type60 FromValue(string value) => FromValueCore(value);
}
