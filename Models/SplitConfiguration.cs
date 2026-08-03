using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SplitConfiguration
{
    /// <summary>
    /// Your description for the split configuration.
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public required string Description { get; init; }

    /// <summary>
    /// Array of rules that define the split configuration behavior.
    /// </summary>
    [JsonPropertyName("rules")]
    public required IReadOnlyList<SplitConfigurationRule> Rules { get; init; }

    /// <summary>
    /// Unique identifier of the split configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitConfigurationId")]
    public string? SplitConfigurationId { get; init; }
}
