using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CapitalGrantInfo
{
    /// <summary>
    /// An object containing the details of the receiving party of the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparty")]
    public GrantInfoCounterparty2? Counterparty { get; init; }

    /// <summary>
    /// The identifier of the grant account used for the grant.
    /// </summary>
    [JsonPropertyName("grantAccountId")]
    public required string GrantAccountId { get; init; }

    /// <summary>
    /// The identifier of the grant offer that has been selected and from which the grant details will be used.
    /// </summary>
    [JsonPropertyName("grantOfferId")]
    public required string GrantOfferId { get; init; }
}
