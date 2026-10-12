using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Reference to resources connected with the store.
/// </summary>
public record Links7
{
    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }
}
