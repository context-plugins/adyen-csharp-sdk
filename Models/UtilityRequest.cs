using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UtilityRequest
{
    /// <summary>
    /// The list of origin domains, for which origin keys are requested.
    /// </summary>
    [JsonPropertyName("originDomains")]
    public required IReadOnlyList<string> OriginDomains { get; init; }
}
