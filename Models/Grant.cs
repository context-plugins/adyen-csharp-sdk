using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Grant
{
    /// <summary>
    /// Contains information about the balances of the grant.
    /// </summary>
    [JsonPropertyName("balances")]
    public required CapitalBalance Balances { get; init; }

    /// <summary>
    /// Contains the details of the party that receives the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public GrantCounterparty? Counterparty { get; init; }

    /// <summary>
    /// The unique identifier of the grant account that tracks this grant.
    /// </summary>
    [JsonPropertyName("grantAccountId")]
    public required string GrantAccountId { get; init; }

    /// <summary>
    /// The unique identifier of the selected offer. Adyen uses the details of the selected offer to create a grant.
    /// </summary>
    [JsonPropertyName("grantOfferId")]
    public required string GrantOfferId { get; init; }

    /// <summary>
    /// The unique identifier of the grant reference.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Contains the status of the grant.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status25 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
