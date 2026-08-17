using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RegisterScaFinalResponse
{
    /// <summary>
    /// Specifies if the registration was initiated successfully.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }
}
