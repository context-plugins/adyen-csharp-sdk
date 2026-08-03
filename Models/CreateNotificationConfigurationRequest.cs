using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateNotificationConfigurationRequest
{
    [JsonPropertyName("configurationDetails")]
    public required NotificationConfigurationDetails ConfigurationDetails { get; init; }
}
