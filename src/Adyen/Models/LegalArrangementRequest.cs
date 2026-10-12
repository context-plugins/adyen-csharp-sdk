using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record LegalArrangementRequest
{
    /// <summary>
    /// The code of the legal arrangement to be deleted. If you also send <c>legalArrangementEntityCodes</c>, only the entities listed will be deleted.
    /// </summary>
    [JsonPropertyName("legalArrangementCode")]
    public required string LegalArrangementCode { get; init; }

    /// <summary>
    /// List of legal arrangement entities to be deleted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntityCodes")]
    public IReadOnlyList<string>? LegalArrangementEntityCodes { get; init; }
}
