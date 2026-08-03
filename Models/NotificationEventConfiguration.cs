using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NotificationEventConfiguration
{
    [JsonPropertyName("eventType")]
    public required EventType EventType { get; init; }

    [JsonPropertyName("includeMode")]
    public required IncludeMode IncludeMode { get; init; }
}
