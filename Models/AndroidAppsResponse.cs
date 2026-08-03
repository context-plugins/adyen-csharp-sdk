using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AndroidAppsResponse
{
    /// <summary>
    /// Apps uploaded for Android payment terminals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<AndroidApp>? Data { get; init; }
}
