using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Nexo
{
    /// <summary>
    /// The list of local and public URLs to send display notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayUrls")]
    public NotificationUrl2? DisplayUrls { get; init; }

    /// <summary>
    /// The key you share with Adyen to secure local communications when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptionKey")]
    public Key1? EncryptionKey { get; init; }

    /// <summary>
    /// The list of local and public URLs to send event notifications to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventUrls")]
    public EventUrl2? EventUrls { get; init; }

    /// <summary>
    /// One or more URLs to send event messages to when using Terminal API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nexoEventUrls")]
    public IReadOnlyList<string>? NexoEventUrls { get; init; }

    /// <summary>
    /// Configures sending event notifications by pressing a button on a terminal, for example used for pay-at-table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public Notification2? Notification { get; init; }
}
