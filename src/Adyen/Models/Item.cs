using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The token requestor is an entity who requested tokenization of the card for secure payments.
/// </summary>
public record Item
{
    /// <summary>
    /// The value to provide in the result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The display name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
