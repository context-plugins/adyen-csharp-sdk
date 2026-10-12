using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ThirdPartyTokenRedundancyInfo
{
    /// <summary>
    /// Request-specific parameter values to populate the template placeholders. Each key must match a placeholder defined in the template referenced by <c>requestTemplateCode</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestParameters")]
    public IReadOnlyDictionary<string, string>? RequestParameters { get; init; }

    /// <summary>
    /// Identifier for the third-party token request template configured in your Adyen account. This template defines the structure and endpoint for token requests.
    /// </summary>
    [JsonPropertyName("requestTemplateCode")]
    public required string RequestTemplateCode { get; init; }
}
