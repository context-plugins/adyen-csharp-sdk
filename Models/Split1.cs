using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Split1
{
    /// <summary>
    /// The unique identifier of the account to which the split amount is booked. Required if <c>type</c> is <b>MarketPlace</b> or <b>BalanceAccount</b>.
    /// <list type="bullet">
    ///   <item><description><see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>: The <see href="https://docs.adyen.com/api-explorer/Account/latest/post/updateAccount#request-accountCode"><c>accountCode</c></see> of the account to which the split amount is booked.</description></item>
    ///   <item><description><see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see>: The <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/get/balanceAccounts/_id_#path-id"><c>balanceAccountId</c></see> of the account to which the split amount is booked.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    /// <summary>
    /// The amount of the split item.
    /// <list type="bullet">
    ///   <item><description>Required for all split types in the <see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>.</description></item>
    ///   <item><description>Required if <c>type</c> is <b>BalanceAccount</b>, <b>Commission</b>, <b>Default</b>, or <b>VAT</b> in your <see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see> integration.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public SplitAmount? Amount { get; init; }

    /// <summary>
    /// Your description for the split item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Your unique reference for the part of the payment booked to the specified <c>account</c>.
    /// <para>
    /// This is required if <c>type</c> is <b>MarketPlace</b> (<see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>) or <b>BalanceAccount</b> (<see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see>).
    /// </para>
    /// <para>
    /// For the other types, we also recommend providing a <b>unique</b> reference so you can reconcile the split and the associated payment in the transaction overview and in the reports.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

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
    [JsonPropertyName("type")]
    public required Type60 Type { get; init; }
}
