using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Grants
{
    /// <summary>
    /// Contains a list of the grants that the account holder has received.
    /// </summary>
    [JsonPropertyName("grants")]
    public required IReadOnlyList<Grant> GrantsValue { get; init; }
}
