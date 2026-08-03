using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Localization
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
