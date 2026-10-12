using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record MerchantAccount
{
    /// <summary>
    /// List of terminals assigned to this merchant account as in-store terminals. This means that the terminal is ready to be boarded, or is already boarded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inStoreTerminals")]
    public IReadOnlyList<string>? InStoreTerminals { get; init; }

    /// <summary>
    /// List of terminals assigned to the inventory of this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventoryTerminals")]
    public IReadOnlyList<string>? InventoryTerminals { get; init; }

    /// <summary>
    /// The merchant account.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccountValue { get; init; }

    /// <summary>
    /// Array of stores under this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stores")]
    public IReadOnlyList<Store1>? Stores { get; init; }
}
