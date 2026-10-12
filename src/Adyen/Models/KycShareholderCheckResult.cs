using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record KycShareholderCheckResult
{
    /// <summary>
    /// A list of the checks and their statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checks")]
    public IReadOnlyList<KycCheckStatusData>? Checks { get; init; }

    /// <summary>
    /// The unique ID of the legal arrangement to which the shareholder belongs, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementCode")]
    public string? LegalArrangementCode { get; init; }

    /// <summary>
    /// The unique ID of the legal arrangement entity to which the shareholder belongs, if applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntityCode")]
    public string? LegalArrangementEntityCode { get; init; }

    /// <summary>
    /// The code of the shareholder to which the check applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderCode")]
    public string? ShareholderCode { get; init; }
}
