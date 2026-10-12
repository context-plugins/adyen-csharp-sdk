using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateSplitConfigurationLogicRequest
{
    /// <summary>
    /// Deducts the acquiring fees (the aggregated amount of interchange and scheme fee) from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquiringFees")]
    public AcquiringFees? AcquiringFees { get; init; }

    /// <summary>
    /// Defines whether to book an additional commission for payments to your user's balance account. The commission amount can be defined as a fixed amount (specified in minor units), a percentage (specified in basis points), or both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalCommission")]
    public AdditionalCommission1? AdditionalCommission { get; init; }

    /// <summary>
    /// Deducts the transaction fee due to Adyen under <see href="https://www.adyen.com/knowledge-hub/guides/payments-training-guide/get-the-best-from-your-card-processing">blended rates</see> from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenCommission")]
    public AdyenCommission? AdyenCommission { get; init; }

    /// <summary>
    /// Deducts the fees due to Adyen (markup or commission) from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenFees")]
    public AdyenFees? AdyenFees { get; init; }

    /// <summary>
    /// Deducts the transaction fee due to Adyen under <see href="https://www.adyen.com/what-is-interchange">Interchange ++ pricing</see> from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adyenMarkup")]
    public AdyenMarkup? AdyenMarkup { get; init; }

    /// <summary>
    /// Specifies how and from which balance account(s) to deduct the chargeback amount.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargeback")]
    public Behavior? Chargeback { get; init; }

    /// <summary>
    /// Deducts the chargeback costs from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chargebackCostAllocation")]
    public ChargebackCostAllocation? ChargebackCostAllocation { get; init; }

    /// <summary>
    /// Defines your platform's commission for the processed payments as a fixed amount (specified in minor units), a percentage (specified in basis points), or both. The commission is booked to your platform's liable balance account.
    /// </summary>
    [JsonPropertyName("commission")]
    public required Commission1 Commission { get; init; }

    /// <summary>
    /// Defines the logic for booking the markup paid by the customer for Dynamic Currency Conversion (DCC).
    /// <para>
    /// &gt; This field is in pilot phase, and not yet available for all platforms.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dcc")]
    public SplitDcc2? Dcc { get; init; }

    /// <summary>
    /// Deducts the interchange fee from specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interchange")]
    public Interchange? Interchange { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentFee")]
    public PaymentFee? PaymentFee { get; init; }

    /// <summary>
    /// Specifies how and from which balance account(s) to deduct the refund amount.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>, <b>deductAccordingToSplitRatio</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public Behavior? Refund { get; init; }

    /// <summary>
    /// Deducts the refund costs from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refundCostAllocation")]
    public RefundCostAllocation? RefundCostAllocation { get; init; }

    /// <summary>
    /// Books the amount left over after currency conversion to the specified balance account.
    /// <para>
    /// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remainder")]
    public Remainder? Remainder { get; init; }

    /// <summary>
    /// Deducts the scheme fee from the specified balance account.
    /// <para>
    /// Possible values: <b>deductFromLiableAccount</b>, <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schemeFee")]
    public SchemeFee? SchemeFee { get; init; }

    /// <summary>
    /// Unique identifier of the collection of split instructions that are applied when the rule conditions are met.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitLogicId")]
    public string? SplitLogicId { get; init; }

    /// <summary>
    /// Books the surcharge amount to the specified balance account.
    /// <para>
    /// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge3? Surcharge { get; init; }

    /// <summary>
    /// Books the tips (gratuity) to the specified balance account.
    /// <para>
    /// Possible values: <b>addToLiableAccount</b>, <b>addToOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip")]
    public Tip? Tip { get; init; }
}
