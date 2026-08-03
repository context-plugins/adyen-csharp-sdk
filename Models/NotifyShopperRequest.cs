using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NotifyShopperRequest
{
    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    /// <summary>
    /// Date on which the subscription amount will be debited from the shopper. In YYYY-MM-DD format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingDate")]
    public string? BillingDate { get; init; }

    /// <summary>
    /// Sequence of the debit. Depends on Frequency and Billing Attempts Rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingSequenceNumber")]
    public string? BillingSequenceNumber { get; init; }

    /// <summary>
    /// Reference of Pre-debit notification that is displayed to the shopper. Optional field. Maps to reference if missing
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayedReference")]
    public string? DisplayedReference { get; init; }

    /// <summary>
    /// The merchant account identifier with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// Pre-debit notification reference sent by the merchant. This is a mandatory field
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The ID that uniquely identifies the shopper.
    /// <para>
    /// This <c>shopperReference</c> must be the same as the <c>shopperReference</c> used in the initial payment.
    /// </para>
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    public string? StoredPaymentMethodId { get; init; }
}
