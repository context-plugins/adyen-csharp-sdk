using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ScheduleAccountUpdaterRequest
{
    /// <summary>
    /// This field contains additional data, which may be required for a particular request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// Credit card data.
    /// <para>
    /// Optional if <c>shopperReference</c> and <c>selectedRecurringDetailReference</c> are provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card? Card { get; init; }

    /// <summary>
    /// Account of the merchant.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// A reference that merchants can apply for the call.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The selected detail recurring reference.
    /// <para>
    /// Optional if <c>card</c> is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedRecurringDetailReference")]
    public string? SelectedRecurringDetailReference { get; init; }

    /// <summary>
    /// The reference of the shopper that owns the recurring contract.
    /// <para>
    /// Optional if <c>card</c> is provided.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }
}
