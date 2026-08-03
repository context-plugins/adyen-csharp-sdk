using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PredefinedContent2
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
}
