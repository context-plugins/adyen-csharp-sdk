using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Links
{
    /// <summary>
    /// Link to the resource itself.
    /// </summary>
    [JsonPropertyName("self")]
    public required LinksElement6 Self { get; init; }
}
