using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentAmountUpdateRequest
{
    /// <summary>
    /// The type of adjustment. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>cardholderInitiatedTransaction</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>merchantInitiatedTransaction</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustAuthType")]
    public AdjustAuthType? AdjustAuthType { get; init; }

    /// <summary>
    /// The required data to make a <see href="https://docs.adyen.com/online-payments/adjust-authorisation">synchronous authorization adjustment</see>. Pass the corresponding value from the <c>/payments</c> response or webhook message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustAuthorisationData")]
    public string? AdjustAuthorisationData { get; init; }

    /// <summary>
    /// The updated amount. The <c>currency</c> must match the currency used in authorisation.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount29 Amount { get; init; }

    /// <summary>
    /// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfo? ApplicationInfo { get; init; }

    /// <summary>
    /// The reason for the amount update. Possible values:
    /// * <b>delayedCharge</b>
    /// * <b>noShow</b>
    /// * <b>installment</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryUsage")]
    public IndustryUsage1? IndustryUsage { get; init; }

    /// <summary>
    /// Price and product information of the refunded items, required for <see href="https://docs.adyen.com/online-payments/refund#refund-a-payment">partial refunds</see>.
    /// &gt; This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Authentication data from a <see href="https://en.wikipedia.org/wiki/Merchant_plug-in">merchant plug-in (MPI)</see> like Mastercard SecureCode, Visa Secure, or Cartes Bancaires. Required for cardholder-initiated transaction (CIT) adjustments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public ThreeDSecureData3? MpiData { get; init; }

    /// <summary>
    /// Your reference for the amount update request. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to process payments for <see href="https://docs.adyen.com/marketplaces/process-payments">marketplaces</see> or <see href="https://docs.adyen.com/platforms/process-payments">platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }
}
