using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for localization.
/// </summary>
public record Localization1
{
    /// <summary>
    /// Language of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// Secondary language of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondaryLanguage")]
    public string? SecondaryLanguage { get; init; }

    /// <summary>
    /// The time zone of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }
}
