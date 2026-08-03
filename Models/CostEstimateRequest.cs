using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CostEstimateRequest
{
    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assumptions")]
    public CostEstimateAssumptions? Assumptions { get; init; }

    /// <summary>
    /// The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.
    /// <para>
    /// &gt; Either the <c>cardNumber</c> or <c>encryptedCardNumber</c> field must be provided in a payment request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNumber")]
    [StringLength(19, MinimumLength = 4)]
    public string? CardNumber { get; init; }

    /// <summary>
    /// Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Checkout Card Component or Secured Fields Component, and must contain the <c>encryptedCardNumber</c> field.
    /// <para>
    /// &gt; Either the <c>cardNumber</c> or <c>encryptedCardNumber</c> field must be provided in a payment request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedCardNumber")]
    public string? EncryptedCardNumber { get; init; }

    /// <summary>
    /// The merchant account identifier you want to process the (transaction) request with.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDetails")]
    public MerchantDetails? MerchantDetails { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring")]
    public Recurring3? Recurring { get; init; }

    /// <summary>
    /// The <c>recurringDetailReference</c> you want to use for this cost estimate. The value <c>LATEST</c> can be used to select the most recently stored recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedRecurringDetailReference")]
    public string? SelectedRecurringDetailReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction1? ShopperInteraction { get; init; }

    /// <summary>
    /// Required for recurring payments.
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }
}
