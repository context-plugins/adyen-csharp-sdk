using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record KyccheckStatusData
{
    /// <summary>
    /// A list of the fields required for execution of the check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requiredFields")]
    public IReadOnlyList<string>? RequiredFields { get; init; }

    [JsonPropertyName("status")]
    public required Status3 Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public KyccheckSummary? Summary { get; init; }

    [JsonPropertyName("type")]
    public required Type2 Type { get; init; }
}
