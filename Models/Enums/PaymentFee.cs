using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Deducts all transaction fees incurred by the payment from the specified balance account. The transaction fees include the acquiring fees (interchange and scheme fee), and the fees due to Adyen (markup or commission). You can book any and all these fees to different balance account by specifying other transaction fee parameters in your split configuration profile:
/// <list type="bullet">
///   <item><description><see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId"><c>adyenCommission</c></see>/splitConfigurations#request-rules-splitLogic-adyenCommission): The transaction fee due to Adyen under <see href="https://www.adyen.com/knowledge-hub/interchange-fees-explained#interchange-vs-blended">blended rates</see>.</description></item>
///   <item><description><see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId"><c>adyenMarkup</c></see>/splitConfigurations#request-rules-splitLogic-adyenMarkup): The transaction fee due to Adyen under <see href="https://www.adyen.com/knowledge-hub/interchange-fees-explained#interchange-vs-blended">Interchange ++ pricing</see>.</description></item>
///   <item><description><see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId"><c>schemeFee</c></see>/splitConfigurations#request-rules-splitLogic-schemeFee): The fee paid to the card scheme for using their network.</description></item>
///   <item><description><see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId"><c>interchange</c></see>/splitConfigurations#request-rules-splitLogic-interchange): The fee paid to the issuer for each payment transaction made with the card network.</description></item>
///   <item><description><see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId"><c>adyenFees</c></see>/splitConfigurations#request-rules-splitLogic-adyenFees): The aggregated amount of Adyen's commission and markup.</description></item>
///   <item><description><see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId"><c>acquiringFees</c></see>/splitConfigurations#request-rules-splitLogic-acquiringFees): The aggregated amount of the interchange and scheme fees.</description></item>
/// </list>
/// <para>
/// If you don't include at least one transaction fee type in the <c>splitLogic</c> object, Adyen updates the payment request with the <c>paymentFee</c> parameter, booking all transaction fees to your platform's liable balance account.
/// </para>
/// <para>
/// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentFee>))]
public sealed record PaymentFee : StringEnum<PaymentFee>
{
    private PaymentFee(string value) : base(value)
    {
    }

    public static readonly PaymentFee DeductFromLiableAccount = new("deductFromLiableAccount");

    public static readonly PaymentFee DeductFromOneBalanceAccount = new("deductFromOneBalanceAccount");

    public static PaymentFee FromValue(string value) => FromValueCore(value);
}
