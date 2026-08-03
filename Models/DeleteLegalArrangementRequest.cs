using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteLegalArrangementRequest
{
    /// <summary>
    /// The code of the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// List of legal arrangements.
    /// </summary>
    [JsonPropertyName("legalArrangements")]
    public required IReadOnlyList<LegalArrangementRequest> LegalArrangements { get; init; }
}
