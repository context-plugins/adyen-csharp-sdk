using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AuthorisedCardUsers
{
    /// <summary>
    /// The legal entity IDs of the authorized card users linked to the specified payment instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntityIds")]
    public IReadOnlyList<string>? LegalEntityIds { get; init; }
}
