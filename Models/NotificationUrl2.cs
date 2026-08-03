using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The list of local and public URLs to send display notifications to when using Terminal API.
/// </summary>
public record NotificationUrl2
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
