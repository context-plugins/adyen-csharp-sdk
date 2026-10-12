using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StoredPaymentMethod3
{
    /// <summary>
    /// The bank account number (without separators).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountNumber")]
    public string? BankAccountNumber { get; init; }

    /// <summary>
    /// The location id of the bank. The field value is <c>nil</c> in most cases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankLocationId")]
    public string? BankLocationId { get; init; }

    /// <summary>
    /// The brand of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// The shopper’s Cash App Pay Cashtag.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashtag")]
    public string? Cashtag { get; init; }

    /// <summary>
    /// The two-digit month when the card expires
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryMonth")]
    public string? ExpiryMonth { get; init; }

    /// <summary>
    /// The last two digits of the year the card expires. For example, <b>22</b> for the year 2022.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryYear")]
    public string? ExpiryYear { get; init; }

    /// <summary>
    /// The token issued by an external tokenization service representing the shopper's payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalToken")]
    public string? ExternalToken { get; init; }

    /// <summary>
    /// The name of the payment method holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holderName")]
    public string? HolderName { get; init; }

    /// <summary>
    /// The IBAN of the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public string? Iban { get; init; }

    /// <summary>
    /// A unique identifier of this stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The shopper’s issuer account label
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// The last four digits of the PAN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastFour")]
    public string? LastFour { get; init; }

    /// <summary>
    /// The display name of the stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

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
    /// The name of the bank account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ownerName")]
    public string? OwnerName { get; init; }

    /// <summary>
    /// The shopper’s email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The supported recurring processing models for this stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportedRecurringProcessingModels")]
    public IReadOnlyList<string>? SupportedRecurringProcessingModels { get; init; }

    /// <summary>
    /// The supported shopper interactions for this stored payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportedShopperInteractions")]
    public IReadOnlyList<string>? SupportedShopperInteractions { get; init; }

    /// <summary>
    /// The type of payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
