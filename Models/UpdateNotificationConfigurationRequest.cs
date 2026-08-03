using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdateNotificationConfigurationRequest
{
    [JsonPropertyName("configurationDetails")]
    public required NotificationConfigurationDetails ConfigurationDetails { get; init; }
}
