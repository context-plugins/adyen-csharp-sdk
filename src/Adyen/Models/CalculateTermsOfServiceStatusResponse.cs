using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CalculateTermsOfServiceStatusResponse
{
    /// <summary>
    /// The type of Terms of Service that the legal entity needs to accept. If empty, no Terms of Service needs to be accepted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceTypes")]
    public IReadOnlyList<TermsOfServiceType>? TermsOfServiceTypes { get; init; }
}
