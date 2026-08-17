using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdateNotificationConfigurationRequest
{
    /// <summary>
    /// Details of the notification subscription configuration to be updated.
    /// </summary>
    [JsonPropertyName("configurationDetails")]
    public required NotificationConfigurationDetails3 ConfigurationDetails { get; init; }
}
