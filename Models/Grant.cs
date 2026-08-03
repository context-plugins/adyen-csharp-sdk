using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Grant
{
    [JsonPropertyName("balances")]
    public required Balances Balances { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public Counterparty10? Counterparty { get; init; }

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

    [JsonPropertyName("status")]
    public required Status8 Status { get; init; }
}
