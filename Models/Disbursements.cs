using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Disbursements
{
    /// <summary>
    /// Contains a list of all disbursements related to the specified grant.
    /// </summary>
    [JsonPropertyName("disbursements")]
    public required IReadOnlyList<Disbursement> DisbursementsValue { get; init; }
}
