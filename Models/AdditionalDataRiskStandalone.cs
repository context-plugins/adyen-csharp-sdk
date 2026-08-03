using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataRiskStandalone
{
    /// <summary>
    /// Shopper's country of residence in the form of ISO standard 3166 2-character country codes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.CountryCode")]
    public string? PayPalCountryCode { get; init; }

    /// <summary>
    /// Shopper's email.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.EmailId")]
    public string? PayPalEmailId { get; init; }

    /// <summary>
    /// Shopper's first name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.FirstName")]
    public string? PayPalFirstName { get; init; }

    /// <summary>
    /// Shopper's last name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.LastName")]
    public string? PayPalLastName { get; init; }

    /// <summary>
    /// Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.PayerId")]
    public string? PayPalPayerId { get; init; }

    /// <summary>
    /// Shopper's phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.Phone")]
    public string? PayPalPhone { get; init; }

    /// <summary>
    /// Allowed values:
    /// * <b>Eligible</b> — Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.
    /// <list type="bullet">
    ///   <item><description><b>PartiallyEligible</b> — Merchant is protected by PayPal's Seller Protection Policy for Item Not Received.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Ineligible</b> — Merchant is not protected under the Seller Protection Policy.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.ProtectionEligibility")]
    public string? PayPalProtectionEligibility { get; init; }

    /// <summary>
    /// Unique transaction ID of the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PayPal.TransactionId")]
    public string? PayPalTransactionId { get; init; }

    /// <summary>
    /// Raw AVS result received from the acquirer, where available. Example: D
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("avsResultRaw")]
    public string? AvsResultRaw { get; init; }

    /// <summary>
    /// The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for <see href="https://docs.adyen.com/online-payments/tokenization">tokenized card request</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bin")]
    public string? Bin { get; init; }

    /// <summary>
    /// Raw CVC result received from the acquirer, where available. Example: 1
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvcResultRaw")]
    public string? CvcResultRaw { get; init; }

    /// <summary>
    /// Unique identifier or token for the shopper's card details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskToken")]
    public string? RiskToken { get; init; }

    /// <summary>
    /// A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDAuthenticated")]
    public string? ThreeDauthenticated { get; init; }

    /// <summary>
    /// A Boolean value indicating whether 3DS was offered for this payment. Example: true
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDOffered")]
    public string? ThreeDoffered { get; init; }

    /// <summary>
    /// Required for PayPal payments only. The only supported value is: <b>paypal</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenDataType")]
    public string? TokenDataType { get; init; }
}
