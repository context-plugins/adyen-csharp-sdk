using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CapitalGrants
{
    /// <summary>
    /// The unique identifier of the grant.
    /// </summary>
    [JsonPropertyName("grants")]
    public required IReadOnlyList<CapitalGrant> Grants { get; init; }
}
