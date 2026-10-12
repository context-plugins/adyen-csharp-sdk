using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record AuthorisedCardUsers
{
    /// <summary>
    /// The legal entity IDs of the authorized card users linked to the specified payment instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntityIds")]
    public IReadOnlyList<string>? LegalEntityIds { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
