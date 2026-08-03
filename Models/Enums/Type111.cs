using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The part of the payment you want to book to the specified <c>account</c>.
/// <para>
/// Possible values for the <see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see>:
/// * <b>BalanceAccount</b>: Books part of the payment (specified in <c>amount</c>) to the specified <c>account</c>.
/// * Transaction fees types that you can book to the specified <c>account</c>:
///    * <b>AcquiringFees</b>: The aggregated amount of the interchange and scheme fees.
///    * <b>PaymentFee</b>: The aggregated amount of all transaction fees.
///    * <b>AdyenFees</b>: The aggregated amount of Adyen's commission and markup fees.
///    * <b>AdyenCommission</b>: The transaction fees due to Adyen under <see href="https://www.adyen.com/knowledge-hub/interchange-fees-explained">blended rates</see>.
///    * <b>AdyenMarkup</b>: The transaction fees due to Adyen under <see href="https://www.adyen.com/knowledge-hub/interchange-fees-explained">Interchange ++ pricing</see>.
///    * <b>Interchange</b>: The fees paid to the issuer for each payment made with the card network.
///    * <b>SchemeFee</b>: The fees paid to the card scheme for using their network.
/// * <b>Commission</b>: Your platform's commission on the payment (specified in <c>amount</c>), booked to your liable balance account.
/// * <b>Remainder</b>: The amount left over after a currency conversion, booked to the specified <c>account</c>.
/// * <b>Surcharge</b>: The payment acceptance fee imposed by the card scheme or debit network provider, paid by your user's customer.
/// * <b>TopUp</b>: Allows you and your users to top up balance accounts using direct debit, card payments, or other payment methods.
/// * <b>VAT</b>: The value-added tax charged on the payment, booked to your platforms liable balance account.
/// * <b>Default</b>: In very specific use cases, allows you to book the specified <c>amount</c> to the specified <c>account</c>. For more information, contact Adyen support.
/// </para>
/// <para>
/// Possible values for the <see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>: <b>Commission</b>, <b>Default</b>, <b>MarketPlace</b>, <b>PaymentFee</b>, <b>VAT</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type111>))]
public sealed record Type111 : StringEnum<Type111>
{
    private Type111(string value) : base(value)
    {
    }

    public static readonly Type111 AcquiringFees = new("AcquiringFees");

    public static readonly Type111 AdyenCommission = new("AdyenCommission");

    public static readonly Type111 AdyenFees = new("AdyenFees");

    public static readonly Type111 AdyenMarkup = new("AdyenMarkup");

    public static readonly Type111 BalanceAccount = new("BalanceAccount");

    public static readonly Type111 Commission = new("Commission");

    public static readonly Type111 Default = new("Default");

    public static readonly Type111 Interchange = new("Interchange");

    public static readonly Type111 MarketPlace = new("MarketPlace");

    public static readonly Type111 PaymentFee = new("PaymentFee");

    public static readonly Type111 Remainder = new("Remainder");

    public static readonly Type111 SchemeFee = new("SchemeFee");

    public static readonly Type111 Surcharge = new("Surcharge");

    public static readonly Type111 Tip = new("Tip");

    public static readonly Type111 TopUp = new("TopUp");

    public static readonly Type111 Vat = new("VAT");

    public static Type111 FromValue(string value) => FromValueCore(value);
}
