using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for a Terminal API integration.
/// </summary>
public record Nexo1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayUrls")]
    public NotificationUrl? DisplayUrls { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionKey")]
    public Key? EncryptionKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventUrls")]
    public EventUrl? EventUrls { get; init; }

    /// <summary>
    /// One or more URLs to send event messages to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nexoEventUrls")]
    public IReadOnlyList<string>? NexoEventUrls { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public Notification? Notification { get; init; }
}
