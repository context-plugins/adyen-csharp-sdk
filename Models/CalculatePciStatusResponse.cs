using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CalculatePciStatusResponse
{
    /// <summary>
    /// Indicates if the user is required to sign PCI questionnaires. If <b>false</b>, they do not need to sign any questionnaires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signingRequired")]
    public bool? SigningRequired { get; init; }
}
