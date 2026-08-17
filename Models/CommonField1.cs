using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Adyen-developed software to get payment details. For example, Checkout SDK, Secured Fields SDK, etc.
/// </summary>
public record CommonField1
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
