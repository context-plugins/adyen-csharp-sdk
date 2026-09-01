using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SoundContent
{
    /// <summary>
    /// Possible values:
    /// * <b>MessageRef</b>
    /// * <b>SoundRef</b>
    /// * <b>Text</b>
    /// </summary>
    [JsonPropertyName("SoundFormat")]
    public required SoundFormat1 SoundFormat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Language")]
    [RegularExpression("^[a-z]{2,2}$")]
    public string? Language { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReferenceID")]
    [RegularExpression("^.+$")]
    public string? ReferenceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Text")]
    [RegularExpression("^.+$")]
    public string? Text { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
