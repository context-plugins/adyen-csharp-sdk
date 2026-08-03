using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThreeDsavailabilityRequest
{
    /// <summary>
    /// This field contains additional data, which may be required for a particular request.
    /// <para>
    /// The <c>additionalData</c> object consists of entries, each of which includes the key and value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// List of brands.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brands")]
    public IReadOnlyList<string>? Brands { get; init; }

    /// <summary>
    /// Card number or BIN.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNumber")]
    public string? CardNumber { get; init; }

    /// <summary>
    /// The merchant account identifier.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// A recurring detail reference corresponding to a card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }
}
