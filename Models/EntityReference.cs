using System.Text.Json.Serialization;

namespace Adyen.Models;

public record EntityReference
{
    /// <summary>
    /// The unique identifier of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
