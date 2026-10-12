using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AdditionalDataCommon
{
    /// <summary>
    /// Triggers test scenarios that allow to replicate certain acquirer response codes. See <see href="https://docs.adyen.com/development-resources/testing/result-codes/">Testing result codes and refusal reasons</see> to learn about the possible values, and the <c>refusalReason</c> values you can trigger.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RequestedTestAcquirerResponseCode")]
    public string? RequestedTestAcquirerResponseCode { get; init; }

    /// <summary>
    /// Triggers test scenarios that allow to replicate certain communication errors.
    /// <para>
    /// Allowed values:
    /// * <b>NO_CONNECTION_AVAILABLE</b> – There wasn't a connection available to service the outgoing communication.
    /// This is a transient, retriable error since no messaging could be initiated to an issuing system (or third-party acquiring system). Therefore, the header Transient-Error: true is returned in the response. A subsequent request using the same idempotency key will be processed as if it was the first request.
    /// * <b>IOEXCEPTION_RECEIVED</b> – Something went wrong during transmission of the message or receiving the response.
    /// This is a classified as non-transient because the message could have been received by the issuing party and been acted upon. No transient error header is returned. If using idempotency, the (error) response is stored as the final result for the idempotency key. Subsequent messages with the same idempotency key not be processed beyond returning the stored response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RequestedTestErrorResponseCode")]
    public string? RequestedTestErrorResponseCode { get; init; }

    /// <summary>
    /// Set to true to authorise a part of the requested amount in case the cardholder does not have enough funds on their account.
    /// If a payment was partially authorised, the response includes resultCode: PartiallyAuthorised and the authorised amount in additionalData.authorisedAmountValue.
    /// To enable this functionality, contact our Support Team.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowPartialAuth")]
    public string? AllowPartialAuth { get; init; }

    /// <summary>
    /// Flags a card payment request for either pre-authorisation or final authorisation. For more information, refer to <see href="https://docs.adyen.com/online-payments/adjust-authorisation#authorisation-types">Authorisation types</see>.
    /// <para>
    /// Allowed values:
    /// * <b>PreAuth</b> – flags the payment request to be handled as a pre-authorisation.
    /// * <b>FinalAuth</b> – flags the payment request to be handled as a final authorisation.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisationType")]
    public string? AuthorisationType { get; init; }

    /// <summary>
    /// Set to <b>true</b> to enable <see href="https://docs.adyen.com/online-payments/auto-rescue/">Auto Rescue</see> for a transaction. Use the <c>maxDaysToRescue</c> to specify a rescue window.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoRescue")]
    public string? AutoRescue { get; init; }

    /// <summary>
    /// Allows you to determine or override the acquirer account that should be used for the transaction.
    /// <para>
    /// If you need to process a payment with an acquirer different from a default one, you can set up a corresponding configuration on the Adyen payments platform. Then you can pass a custom routing flag in a payment request's additional data to target a specific acquirer.
    /// </para>
    /// <para>
    /// To enable this functionality, contact <see href="https://www.adyen.help/hc/en-us/requests/new">Support</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customRoutingFlag")]
    public string? CustomRoutingFlag { get; init; }

    /// <summary>
    /// In case of <see href="https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation">asynchronous authorisation adjustment</see>, this field denotes why the additional payment is made.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>NoShow</b>: An incremental charge is carried out because of a no-show for a guaranteed reservation.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>DelayedCharge</b>: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryUsage")]
    public IndustryUsage? IndustryUsage { get; init; }

    /// <summary>
    /// Set to <b>true</b> to require <see href="https://docs.adyen.com/online-payments/capture">manual capture</see> for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manualCapture")]
    public string? ManualCapture { get; init; }

    /// <summary>
    /// The rescue window for a transaction, in days, when <c>autoRescue</c> is set to <b>true</b>. You can specify a value between 1 and 48.
    /// <list type="bullet">
    ///   <item><description>For <see href="https://docs.adyen.com/online-payments/auto-rescue/cards/">cards</see>, the default is one calendar month.
    ///     <list type="bullet">
    ///       <item><description>For <see href="https://docs.adyen.com/online-payments/auto-rescue/sepa/">SEPA</see>, the default is 42 days.</description></item>
    ///     </list>
    ///   </description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxDaysToRescue")]
    public string? MaxDaysToRescue { get; init; }

    /// <summary>
    /// Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain. This field is required for token-based transactions where Adyen does not tokenize the card.
    /// <para>
    /// Transaction identifier from card schemes, for example, Mastercard Trace ID or the Visa Transaction ID.
    /// </para>
    /// <para>
    /// Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.
    /// </para>
    /// <para>
    /// Make sure you are sending <c>shopperInteraction</c> <b>ContAuth</b> and <c>recurringProcessingModel</c> <b>Subscription</b> or <b>UnscheduledCardOnFile</b> to ensure that the transaction is classified as MIT.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTxReference")]
    public string? NetworkTxReference { get; init; }

    /// <summary>
    /// Boolean indicator that can be optionally used for performing debit transactions on combo cards (for example, combo cards in Brazil). This is not mandatory but we recommend that you set this to true if you want to use the <c>selectedBrand</c> value to specify how to process the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("overwriteBrand")]
    public string? OverwriteBrand { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the city of the actual merchant's address.
    /// * Format: alpha-numeric.
    /// * Maximum length: 13 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantCity")]
    public string? SubMerchantCity { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the three-letter country code of the actual merchant's address.
    /// * Format: alpha-numeric.
    /// * Fixed length: 3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantCountry")]
    public string? SubMerchantCountry { get; init; }

    /// <summary>
    /// This field is required for transactions performed by registered payment facilitators. This field contains the email address of the sub-merchant.
    /// * Format: Alphanumeric
    /// * Maximum length: 40 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantEmail")]
    public string? SubMerchantEmail { get; init; }

    /// <summary>
    /// This field contains an identifier of the actual merchant when a transaction is submitted via a payment facilitator. The payment facilitator must send in this unique ID.
    /// <para>
    /// A unique identifier per submerchant that is required if the transaction is performed by a registered payment facilitator.
    /// * Format: alpha-numeric.
    /// * Fixed length: 15 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantID")]
    public string? SubMerchantId { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the name of the actual merchant.
    /// * Format: alpha-numeric.
    /// * Maximum length: 22 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantName")]
    public string? SubMerchantName { get; init; }

    /// <summary>
    /// This field is required for transactions performed by registered payment facilitators. This field contains the phone number of the sub-merchant.* Format: Alphanumeric
    /// * Maximum length: 20 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantPhoneNumber")]
    public string? SubMerchantPhoneNumber { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the postal code of the actual merchant's address.
    /// * Format: alpha-numeric.
    /// * Maximum length: 10 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantPostalCode")]
    public string? SubMerchantPostalCode { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator, and if applicable to the country. This field must contain the state code of the actual merchant's address.
    /// * Format: alpha-numeric.
    /// * Maximum length: 3 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantState")]
    public string? SubMerchantState { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the street of the actual merchant's address.
    /// * Format: alpha-numeric.
    /// * Maximum length: 60 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantStreet")]
    public string? SubMerchantStreet { get; init; }

    /// <summary>
    /// This field is required if the transaction is performed by a registered payment facilitator. This field must contain the tax ID of the actual merchant.
    /// * Format: alpha-numeric.
    /// * Fixed length: 11 or 14 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantTaxId")]
    public string? SubMerchantTaxId { get; init; }

    /// <summary>
    /// Allows you to link the transaction to the original or previous one in a subscription/card-on-file chain For Mastercard payments. This field is required for token-based transactions where Adyen does not tokenize the card.
    /// <para>
    /// Transaction identifier from Mastercard.
    /// </para>
    /// <para>
    /// Submit the original transaction ID of the contract in your payment request if you are not tokenizing card details with Adyen and are making a merchant-initiated transaction (MIT) for subsequent charges.
    /// </para>
    /// <para>
    /// Make sure you are sending <c>shopperInteraction</c> <b>ContAuth</b> and <c>recurringProcessingModel</c> <b>Subscription</b> or <b>UnscheduledCardOnFile</b> to ensure that the transaction is classified as MIT.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLinkId")]
    public string? TransactionLinkId { get; init; }
}
