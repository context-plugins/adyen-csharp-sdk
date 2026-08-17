using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The card details.
/// </summary>
public record CheckoutForwardRequestCard2
{
    /// <summary>
    /// The <see href="https://docs.adyen.com/payments-fundamentals/payment-glossary#card-security-code-cvc-cvv-cid">card verification code</see> (1-20 characters). Depending on the card brand, it is also known as:
    /// * CVV2/CVC2 – length: 3 digits
    /// * CID – length: 4 digits
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvc")]
    public string? Cvc { get; init; }

    /// <summary>
    /// The encrypted card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedCardNumber")]
    public string? EncryptedCardNumber { get; init; }

    /// <summary>
    /// The encrypted expiryMonth
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedExpiryMonth")]
    public string? EncryptedExpiryMonth { get; init; }

    /// <summary>
    /// The encrypted card expiry year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedExpiryYear")]
    public string? EncryptedExpiryYear { get; init; }

    /// <summary>
    /// The encrypted security code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedSecurityCode")]
    public string? EncryptedSecurityCode { get; init; }

    /// <summary>
    /// The card expiry month.
    /// Format: 2 digits, zero-padded for single digits. For example:
    /// * 03 = March
    /// * 11 = November
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryMonth")]
    public string? ExpiryMonth { get; init; }

    /// <summary>
    /// The card expiry year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryYear")]
    public string? ExpiryYear { get; init; }

    /// <summary>
    /// The name of the cardholder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holderName")]
    public string? HolderName { get; init; }

    /// <summary>
    /// The card number. Only collect raw card data if you are fully <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">PCI compliant</see>.
    /// Format: Do not use separators.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// Default payment method details. Common for scheme payment methods, and for simple payment method details.
    /// </summary>
    [JsonPropertyName("type")]
    public Type18? Type { get; init; } = Type18.Scheme;
}
