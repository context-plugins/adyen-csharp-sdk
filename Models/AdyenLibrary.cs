using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdyenLibrary
{
    /// <summary>
    /// Name of the field. For example, Name of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Version of the field. For example, Version of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }
}
