using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources linked to the allowed origin.
/// </summary>
public record Links2
{
    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }
}
