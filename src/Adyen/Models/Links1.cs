using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// References to resources connected with this user.
/// </summary>
public record Links1
{
    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }
}
