using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetTermsOfServiceAcceptanceInfosResponse
{
    /// <summary>
    /// The Terms of Service acceptance information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<TermsOfServiceAcceptanceInfo>? Data { get; init; }
}
