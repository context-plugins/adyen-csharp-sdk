using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateNotificationConfigurationRequest
{
    /// <summary>
    /// Details of the prospective notification subscription configuration.
    /// </summary>
    [JsonPropertyName("configurationDetails")]
    public required NotificationConfigurationDetails4 ConfigurationDetails { get; init; }
}
