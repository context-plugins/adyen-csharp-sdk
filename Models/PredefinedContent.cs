using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Reference of a predefined message to display or print.
/// It conveys information related to the predefined message.
/// </summary>
public record PredefinedContent
{
    /// <summary>
    /// Identification of a predefined message to display or print.
    /// </summary>
    [JsonPropertyName("ReferenceID")]
    [RegularExpression("^.+$")]
    public required string ReferenceId { get; init; }

    /// <summary>
    /// Identification of a language.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Language")]
    [RegularExpression("^[a-z]{2,2}$")]
    public string? Language { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
