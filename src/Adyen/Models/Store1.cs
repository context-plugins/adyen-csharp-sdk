using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Store1
{
    /// <summary>
    /// The address of the store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address14? Address { get; init; }

    /// <summary>
    /// The description of the store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The list of terminals assigned to the store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inStoreTerminals")]
    public IReadOnlyList<string>? InStoreTerminals { get; init; }

    /// <summary>
    /// The code of the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccountCode")]
    public string? MerchantAccountCode { get; init; }

    /// <summary>
    /// The status of the store:
    /// <list type="bullet">
    ///   <item><description><c>PreActive</c>: the store has been created, but not yet activated.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>Active</c>: the store has been activated. This means you can process payments for this store.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>Inactive</c>: the store is currently not active.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>InactiveWithModifications</c>: the store is currently not active, but payment modifications such as refunds are possible.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>Closed</c>: the store has been closed.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The code of the store.
    /// </summary>
    [JsonPropertyName("store")]
    public required string Store { get; init; }
}
