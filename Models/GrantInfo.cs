using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public Counterparty12? Counterparty { get; init; }

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
}
