using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OnboardingThemes
{
    /// <summary>
    /// The next page. Only present if there is a next page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    /// <summary>
    /// The previous page. Only present if there is a previous page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    /// <summary>
    /// List of onboarding themes.
    /// </summary>
    [JsonPropertyName("themes")]
    public required IReadOnlyList<OnboardingTheme> Themes { get; init; }
}
