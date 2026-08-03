using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record NotificationUrl
{
    /// <summary>
    /// One or more local URLs to send notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localUrls")]
    public IReadOnlyList<Url>? LocalUrls { get; init; }

    /// <summary>
    /// One or more public URLs to send notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicUrls")]
    public IReadOnlyList<Url>? PublicUrls { get; init; }
}
