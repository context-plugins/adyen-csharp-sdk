using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ResponseAdditionalDataCommon
{
    /// <summary>
    /// The name of the Adyen acquirer account.
    /// <para>
    /// Example: PayPalSandbox_TestAcquirer
    /// </para>
    /// <para>
    /// &gt; Only relevant for PayPal transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerAccountCode")]
    public string? AcquirerAccountCode { get; init; }

    /// <summary>
    /// The name of the acquirer processing the payment request.
    /// <para>
    /// Example: TestPmmAcquirer
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerCode")]
    public string? AcquirerCode { get; init; }

    /// <summary>
    /// The reference number that can be used for reconciliation in case a non-Adyen acquirer is used for settlement.
    /// <para>
    /// Example: 7C9N3FNBKT9
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acquirerReference")]
    public string? AcquirerReference { get; init; }

    /// <summary>
    /// The Adyen alias of the card.
    /// <para>
    /// Example: H167852639363479
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>
    /// The type of the card alias.
    /// <para>
    /// Example: Default
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasType")]
    public string? AliasType { get; init; }

    /// <summary>
    /// Authorisation code:
    /// * When the payment is authorised successfully, this field holds the authorisation code for the payment.
    /// * When the payment is not authorised, this field is empty.
    /// <para>
    /// Example: 58747
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; init; }

    /// <summary>
    /// Merchant ID known by the acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisationMid")]
    public string? AuthorisationMid { get; init; }

    /// <summary>
    /// The currency of the authorised amount, as a three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisedAmountCurrency")]
    public string? AuthorisedAmountCurrency { get; init; }

    /// <summary>
    /// Value of the amount authorised.
    /// <para>
    /// This amount is represented in minor units according to the <see href="https://docs.adyen.com/development-resources/currency-codes">following table</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisedAmountValue")]
    public string? AuthorisedAmountValue { get; init; }

    /// <summary>
    /// The AVS result code of the payment, which provides information about the outcome of the AVS check.
    /// <para>
    /// For possible values, see <see href="https://docs.adyen.com/risk-management/configure-standard-risk-rules/consistency-rules#billing-address-does-not-match-cardholder-address-avs">AVS</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avsResult")]
    public string? AvsResult { get; init; }

    /// <summary>
    /// Raw AVS result received from the acquirer, where available.
    /// <para>
    /// Example: D
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avsResultRaw")]
    public string? AvsResultRaw { get; init; }

    /// <summary>
    /// BIC of a bank account.
    /// <para>
    /// Example: TESTNL01
    /// </para>
    /// <para>
    /// &gt; Only relevant for SEPA Direct Debit transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bic")]
    public string? Bic { get; init; }

    /// <summary>
    /// Includes the co-branded card information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coBrandedWith")]
    public string? CoBrandedWith { get; init; }

    /// <summary>
    /// The result of CVC verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvcResult")]
    public string? CvcResult { get; init; }

    /// <summary>
    /// The raw result of CVC verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvcResultRaw")]
    public string? CvcResultRaw { get; init; }

    /// <summary>
    /// Supported for 3D Secure 2. The unique transaction identifier assigned by the DS to identify a single transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dsTransID")]
    public string? DsTransId { get; init; }

    /// <summary>
    /// The Electronic Commerce Indicator returned from the schemes for the 3DS payment session.
    /// <para>
    /// Example: 02
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eci")]
    public string? Eci { get; init; }

    /// <summary>
    /// The expiry date on the card.
    /// <para>
    /// Example: 6/2016
    /// </para>
    /// <para>
    /// &gt; Returned only in case of a card payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryDate")]
    public string? ExpiryDate { get; init; }

    /// <summary>
    /// The currency of the extra amount charged due to additional amounts set in the skin used in the HPP payment request.
    /// <para>
    /// Example: EUR
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extraCostsCurrency")]
    public string? ExtraCostsCurrency { get; init; }

    /// <summary>
    /// The value of the extra amount charged due to additional amounts set in the skin used in the HPP payment request. The amount is in minor units.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("extraCostsValue")]
    public string? ExtraCostsValue { get; init; }

    /// <summary>
    /// The fraud score due to a particular fraud check. The fraud check name is found in the key of the key-value pair.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudCheck-[itemNr]-[FraudCheckname]")]
    public string? FraudCheckItemNrFraudCheckname { get; init; }

    /// <summary>
    /// Indicates if the payment is sent to manual review.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudManualReview")]
    public string? FraudManualReview { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResultType")]
    public FraudResultType? FraudResultType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudRiskLevel")]
    public FraudRiskLevel? FraudRiskLevel { get; init; }

    /// <summary>
    /// Information regarding the funding type of the card. The possible return values are:
    /// * CHARGE
    /// * CREDIT
    /// * DEBIT
    /// * PREPAID
    /// * PREPAID_RELOADABLE
    /// <list type="bullet">
    ///   <item><description>PREPAID_NONRELOADABLE</description></item>
    ///   <item><description>DEFFERED_DEBIT</description></item>
    /// </list>
    /// <para>
    /// &gt; This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.
    /// </para>
    /// <para>
    /// For receiving this field in the notification, enable <b>Include Funding Source</b> in <b>Notifications</b> &gt; <b>Additional settings</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public string? FundingSource { get; init; }

    /// <summary>
    /// Indicates availability of funds.
    /// <para>
    /// Visa:
    /// * "I" (fast funds are supported)
    /// * "N" (otherwise)
    /// </para>
    /// <para>
    /// Mastercard:
    /// * "I" (product type is Prepaid or Debit, or issuing country is in CEE/HGEM list)
    /// * "N" (otherwise)
    /// </para>
    /// <para>
    /// &gt; Returned when you verify a card BIN or estimate costs, and only if payoutEligible is "Y" or "D".
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsAvailability")]
    public string? FundsAvailability { get; init; }

    /// <summary>
    /// Provides the more granular indication of why a transaction was refused. When a transaction fails with either "Refused", "Restricted Card", "Transaction Not Permitted", "Not supported" or "DeclinedNon Generic" refusalReason from the issuer, Adyen cross references its PSP-wide data for extra insight into the refusal reason. If an inferred refusal reason is available, the <c>inferredRefusalReason</c>, field is populated and the <c>refusalReason</c>, is set to "Not Supported".
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>3D Secure Mandated</description></item>
    ///   <item><description>Closed Account</description></item>
    ///   <item><description>ContAuth Not Supported</description></item>
    ///   <item><description>CVC Mandated</description></item>
    ///   <item><description>Ecommerce Not Allowed</description></item>
    ///   <item><description>Crossborder Not Supported</description></item>
    ///   <item><description>Card Updated</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Low Authrate Bin</description></item>
    ///   <item><description>Non-reloadable prepaid card</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inferredRefusalReason")]
    public string? InferredRefusalReason { get; init; }

    /// <summary>
    /// Indicates if the card is used for business purposes only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isCardCommercial")]
    public string? IsCardCommercial { get; init; }

    /// <summary>
    /// The issuing country of the card based on the BIN list that Adyen maintains.
    /// <para>
    /// Example: JP
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuerCountry")]
    public string? IssuerCountry { get; init; }

    /// <summary>
    /// A Boolean value indicating whether a liability shift was offered for this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("liabilityShift")]
    public string? LiabilityShift { get; init; }

    /// <summary>
    /// The <c>mcBankNetReferenceNumber</c>, is a minimum of six characters and a maximum of nine characters long.
    /// <para>
    /// &gt; Contact Support Team to enable this field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcBankNetReferenceNumber")]
    public string? McBankNetReferenceNumber { get; init; }

    /// <summary>
    /// The Merchant Advice Code (MAC) can be returned by Mastercard issuers for refused payments. If present, the MAC contains information about why the payment failed, and whether it can be retried.
    /// <para>
    /// For more information see <see href="https://docs.adyen.com/development-resources/raw-acquirer-responses#mastercard-merchant-advice-codes">Mastercard Merchant Advice Codes</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAdviceCode")]
    public string? MerchantAdviceCode { get; init; }

    /// <summary>
    /// The reference provided for the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// Indicates the processing flow.
    /// <para>
    /// Possible values:
    /// * <b>sale</b>: You do not need to separately capture the funds, because capture happens automatically as part of the transaction.
    /// * <b>auth</b>: If you have not <see href="https://docs.adyen.com/online-payments/capture#types-of-capture">configured automatic capture for the transaction</see>, you must manually capture the funds.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkProcessingMode")]
    public string? NetworkProcessingMode { get; init; }

    /// <summary>
    /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.
    /// <para>
    /// This contains either the Mastercard Trace ID or the Visa Transaction ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTxReference")]
    public string? NetworkTxReference { get; init; }

    /// <summary>
    /// The owner name of a bank account.
    /// <para>
    /// Only relevant for SEPA Direct Debit transactions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerName")]
    public string? OwnerName { get; init; }

    /// <summary>
    /// The Payment Account Reference (PAR) value links a network token with the underlying primary account number (PAN). The PAR value consists of 29 uppercase alphanumeric characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentAccountReference")]
    public string? PaymentAccountReference { get; init; }

    /// <summary>
    /// The payment method used in the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public string? PaymentMethod { get; init; }

    /// <summary>
    /// The Adyen sub-variant of the payment method used for the payment request.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/development-resources/paymentmethodvariant">PaymentMethodVariant</see>.
    /// </para>
    /// <para>
    /// Example: mcpro
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodVariant")]
    public string? PaymentMethodVariant { get; init; }

    /// <summary>
    /// Indicates whether a payout is eligible or not for this card.
    /// <para>
    /// Visa:
    /// * "Y"
    /// * "N"
    /// </para>
    /// <para>
    /// Mastercard:
    /// * "Y" (domestic and cross-border)
    /// </para>
    /// <list type="bullet">
    ///   <item><description>"D" (only domestic)</description></item>
    ///   <item><description>"N" (no MoneySend)</description></item>
    ///   <item><description>"U" (unknown)</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutEligible")]
    public string? PayoutEligible { get; init; }

    /// <summary>
    /// The response code from the Real Time Account Updater service.
    /// <para>
    /// Possible return values are:
    /// * CardChanged
    /// * CardExpiryChanged
    /// * CloseAccount
    /// </para>
    /// <list type="bullet">
    ///   <item><description>ContactCardAccountHolder</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("realtimeAccountUpdaterStatus")]
    public string? RealtimeAccountUpdaterStatus { get; init; }

    /// <summary>
    /// Message to be displayed on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receiptFreeText")]
    public string? ReceiptFreeText { get; init; }

    /// <summary>
    /// The recurring contract types applicable to the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring.contractTypes")]
    public string? RecurringContractTypes { get; init; }

    /// <summary>
    /// The <c>pspReference</c>, of the first recurring payment that created the recurring detail.
    /// <para>
    /// This functionality requires additional configuration on Adyen's end. To enable it, contact the Support Team.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring.firstPspReference")]
    public string? RecurringFirstPspReference { get; init; }

    /// <summary>
    /// The reference that uniquely identifies the recurring transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring.recurringDetailReference")]
    public string? RecurringRecurringDetailReference { get; init; }

    /// <summary>
    /// The provided reference of the shopper for a recurring transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring.shopperReference")]
    public string? RecurringShopperReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringProcessingModel")]
    public RecurringProcessingModel7? RecurringProcessingModel { get; init; }

    /// <summary>
    /// If the payment is referred, this field is set to true.
    /// <para>
    /// This field is unavailable if the payment is referred and is usually not returned with ecommerce transactions.
    /// </para>
    /// <para>
    /// Example: true
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referred")]
    public string? Referred { get; init; }

    /// <summary>
    /// Raw refusal reason received from the acquirer, where available.
    /// <para>
    /// Example: AUTHORISED
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReasonRaw")]
    public string? RefusalReasonRaw { get; init; }

    /// <summary>
    /// The amount of the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestAmount")]
    public string? RequestAmount { get; init; }

    /// <summary>
    /// The currency of the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestCurrencyCode")]
    public string? RequestCurrencyCode { get; init; }

    /// <summary>
    /// The shopper interaction type of the payment request.
    /// <para>
    /// Example: Ecommerce
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public string? ShopperInteraction { get; init; }

    /// <summary>
    /// The shopperReference passed in the payment request.
    /// <para>
    /// Example: AdyenTestShopperXX
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// The terminal ID used in a point-of-sale payment.
    /// <para>
    /// Example: 06022622
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalId")]
    public string? TerminalId { get; init; }

    /// <summary>
    /// A Boolean value indicating whether 3DS authentication was completed on this payment.
    /// <para>
    /// Example: true
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDAuthenticated")]
    public string? ThreeDauthenticated { get; init; }

    /// <summary>
    /// The raw 3DS authentication result from the card issuer.
    /// <para>
    /// Example: N
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDAuthenticatedResponse")]
    public string? ThreeDauthenticatedResponse { get; init; }

    /// <summary>
    /// A Boolean value indicating whether 3DS was offered for this payment.
    /// <para>
    /// Example: true
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDOffered")]
    public string? ThreeDoffered { get; init; }

    /// <summary>
    /// The raw enrollment result from the 3DS directory services of the card schemes.
    /// <para>
    /// Example: Y
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDOfferedResponse")]
    public string? ThreeDofferedResponse { get; init; }

    /// <summary>
    /// The 3D Secure 2 version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSVersion")]
    public string? ThreeDsversion { get; init; }

    /// <summary>
    /// The reference for the shopper that you sent when tokenizing the payment details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenization.shopperReference")]
    public string? TokenizationShopperReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenization.store.operationType")]
    public TokenizationStoreOperationType? TokenizationStoreOperationType { get; init; }

    /// <summary>
    /// The reference that uniquely identifies tokenized payment details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenization.storedPaymentMethodId")]
    public string? TokenizationStoredPaymentMethodId { get; init; }

    /// <summary>
    /// Returned in the response for Mastercard payments.
    /// <para>
    /// This contains the Mastercard Transaction Link Identifier (TLID).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLinkId")]
    public string? TransactionLinkId { get; init; }

    /// <summary>
    /// The <c>visaTransactionId</c>, has a fixed length of 15 numeric characters.
    /// <para>
    /// &gt; Contact Support Team to enable this field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visaTransactionId")]
    public string? VisaTransactionId { get; init; }

    /// <summary>
    /// The 3DS transaction ID of the 3DS session sent in notifications. The value is Base64-encoded and is returned for transactions with directoryResponse 'N' or 'Y'.
    /// <para>
    /// Example: ODgxNDc2MDg2MDExODk5MAAAAAA=
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xid")]
    public string? Xid { get; init; }
}
