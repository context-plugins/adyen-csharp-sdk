using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteNotificationConfigurationRequest
{
    /// <summary>
    /// A list of IDs of the notification subscription configurations to be deleted.
    /// </summary>
    [JsonPropertyName("notificationIds")]
    public required IReadOnlyList<long> NotificationIds { get; init; }
}
