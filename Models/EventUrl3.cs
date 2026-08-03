using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The list of local and public URLs to send notifications to when using local integrations.
/// </summary>
public record EventUrl3
{
    /// <summary>
    /// One or more local URLs to send event notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventLocalUrls")]
    public IReadOnlyList<Url>? EventLocalUrls { get; init; }

    /// <summary>
    /// One or more public URLs to send event notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventPublicUrls")]
    public IReadOnlyList<Url>? EventPublicUrls { get; init; }
}
