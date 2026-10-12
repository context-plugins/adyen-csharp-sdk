using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DetailsOfTokensThatAreNotStoredWithAdyen
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

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
    [MaxLength(15000)]
    public string? HolderName { get; init; }

    /// <summary>
    /// The card number. Only collect raw card data if you are <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// Identifier used to fetch the token from the external service
    /// </summary>
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public required string StoredPaymentMethodId { get; init; }

    /// <summary>
    /// The external service from which to fetch the token. Supported only for specific companies. Contact Adyen if you want to use this feature.
    /// </summary>
    [JsonPropertyName("subtype")]
    public string Subtype { get; } = "hilton";

    /// <summary>
    /// The type of token. Allowed value: <b>externalToken</b>.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "externalToken";
}
