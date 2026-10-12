using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the information required to store a payment method.
/// </summary>
public record PaymentMethodToStore1
{
    /// <summary>
    /// Secondary brand of the card. For example: <b>plastix</b>, <b>hmclub</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// The card verification code. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvc")]
    public string? Cvc { get; init; }

    /// <summary>
    /// The encrypted card.
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
    /// The name of the card holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holderName")]
    public string? HolderName { get; init; }

    /// <summary>
    /// The card number. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// Set to <b>scheme</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
