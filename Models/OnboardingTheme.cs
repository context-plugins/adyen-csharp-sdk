using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OnboardingTheme
{
    /// <summary>
    /// The creation date of the theme.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The description of the theme.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the theme.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The properties of the theme.
    /// </summary>
    [JsonPropertyName("properties")]
    public required IReadOnlyDictionary<string, string> Properties { get; init; }

    /// <summary>
    /// The date when the theme was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }
}
