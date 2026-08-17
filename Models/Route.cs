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

    /// <summary>
    /// Metadata about the selected provider, including the name and company logo. You can use this information to inform the user about the provider they will be redirected to when they select the link.
    /// </summary>
    [JsonPropertyName("provider")]
    public required Provider2 Provider { get; init; }
}
