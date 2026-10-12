using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CardDonations
{
    /// <summary>
    /// The sequence number for the debit. For example, send <b>2</b> if this is the second debit for the subscription. The sequence number is included in the notification sent to the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingSequenceNumber")]
    public string? BillingSequenceNumber { get; init; }

    /// <summary>
    /// Secondary brand of the card. For example: <b>plastix</b>, <b>hmclub</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cupsecureplus.smscode")]
    public string? CupsecureplusSmscode { get; init; }

    /// <summary>
    /// The card verification code. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvc")]
    public string? Cvc { get; init; }

    /// <summary>
    /// Only include this for JSON Web Encryption (JWE) implementations. The JWE-encrypted card details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedCard")]
    [MaxLength(40000)]
    public string? EncryptedCard { get; init; }

    /// <summary>
    /// The encrypted card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedCardNumber")]
    [MaxLength(15000)]
    public string? EncryptedCardNumber { get; init; }

    /// <summary>
    /// The encrypted card expiry month.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedExpiryMonth")]
    [MaxLength(15000)]
    public string? EncryptedExpiryMonth { get; init; }

    /// <summary>
    /// The encrypted card expiry year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedExpiryYear")]
    [MaxLength(15000)]
    public string? EncryptedExpiryYear { get; init; }

    /// <summary>
    /// This field contains an encrypted, one-time password or an authentication code provided by the cardholder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedPassword")]
    [MaxLength(15000)]
    public string? EncryptedPassword { get; init; }

    /// <summary>
    /// The encrypted card verification code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedSecurityCode")]
    [MaxLength(15000)]
    public string? EncryptedSecurityCode { get; init; }

    /// <summary>
    /// The card expiry month. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryMonth")]
    public string? ExpiryMonth { get; init; }

    /// <summary>
    /// The card expiry year. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryYear")]
    public string? ExpiryYear { get; init; }

    /// <summary>
    /// The encoded fastlane data blob
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fastlaneData")]
    public string? FastlaneData { get; init; }

    /// <summary>
    /// The funding source that should be used when multiple sources are available. For Brazilian combo cards, by default the funding source is credit. To use debit, set this value to <b>debit</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public FundingSource? FundingSource { get; init; }

    /// <summary>
    /// The name of the card holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holderName")]
    [MaxLength(15000)]
    public string? HolderName { get; init; }

    /// <summary>
    /// The transaction identifier from card schemes. This is the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-additionalData-ResponseAdditionalDataCommon-networkTxReference"><c>networkTxReference</c></see> from the response to the first payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkPaymentReference")]
    public string? NetworkPaymentReference { get; init; }

    /// <summary>
    /// The card number. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// The <c>shopperNotificationReference</c> returned in the response when you requested to notify the shopper. Used only for recurring payments in India.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperNotificationReference")]
    public string? ShopperNotificationReference { get; init; }

    /// <summary>
    /// An identifier used for the Click to Pay transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("srcCorrelationId")]
    public string? SrcCorrelationId { get; init; }

    /// <summary>
    /// The SRC reference for the Click to Pay token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("srcDigitalCardId")]
    public string? SrcDigitalCardId { get; init; }

    /// <summary>
    /// The scheme that is being used for Click to Pay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("srcScheme")]
    public string? SrcScheme { get; init; }

    /// <summary>
    /// The reference for the Click to Pay token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("srcTokenReference")]
    public string? SrcTokenReference { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public string? StoredPaymentMethodId { get; init; }

    /// <summary>
    /// Required for mobile integrations. Version of the 3D Secure 2 mobile SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDS2SdkVersion")]
    [MaxLength(12)]
    public string? ThreeDs2SdkVersion { get; init; }

    /// <summary>
    /// Default payment method details. Common for scheme payment methods, and for simple payment method details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type14? Type { get; init; } = Type14.Scheme;
}
