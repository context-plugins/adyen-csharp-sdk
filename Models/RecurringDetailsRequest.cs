using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RecurringDetailsRequest
{
    /// <summary>
    /// The merchant account identifier you want to process the (transaction) request with.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring")]
    public Recurring3? Recurring { get; init; }

    /// <summary>
    /// The reference you use to uniquely identify the shopper (e.g. user ID or account ID).
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }
}
