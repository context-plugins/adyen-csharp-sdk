using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record WebhookSettings
{
    /// <summary>
    /// The list of webhook settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhookSettings")]
    public IReadOnlyList<WebhookSetting>? WebhookSettingsValue { get; init; }
}
