using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains redirection URLs to guide the user to the appropriate page, after a successful payment or a cancellation.
/// </summary>
public record Links1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel")]
    public Href? Cancel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public Href? Success { get; init; }
}
