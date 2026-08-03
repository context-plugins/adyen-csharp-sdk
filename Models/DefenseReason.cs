using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DefenseReason
{
    /// <summary>
    /// Array of defense document types for a specific defense reason. Indicates the document types that you can submit to the schemes to defend this dispute, and whether they are required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defenseDocumentTypes")]
    public IReadOnlyList<DefenseDocumentType>? DefenseDocumentTypes { get; init; }

    /// <summary>
    /// The defense reason code that was selected to defend this dispute.
    /// </summary>
    [JsonPropertyName("defenseReasonCode")]
    public required string DefenseReasonCode { get; init; }

    /// <summary>
    /// Indicates if sufficient defense material has been supplied.
    /// </summary>
    [JsonPropertyName("satisfied")]
    public required bool Satisfied { get; init; }
}
