using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RemediatingAction
{
    /// <summary>
    /// The remediating action code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// A description of how you can resolve the verification error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
