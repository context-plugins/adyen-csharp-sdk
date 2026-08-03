using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetNotificationConfigurationRequest
{
    /// <summary>
    /// The ID of the notification subscription configuration whose details are to be retrieved.
    /// </summary>
    [JsonPropertyName("notificationId")]
    public required long NotificationId { get; init; }
}
