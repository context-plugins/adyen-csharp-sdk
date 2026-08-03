using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Route
{
    /// <summary>
    /// The redirection link. You can use this link to redirect the user to the open banking flow when the user selects it.
    /// </summary>
    [JsonPropertyName("link")]
    [MinLength(1)]
    public required string Link { get; init; }

    [JsonPropertyName("provider")]
    public required Provider Provider { get; init; }
}
