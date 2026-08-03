using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record InputUpdate3
{
    [JsonPropertyName("MessageReference")]
    public required MessageReference1 MessageReference { get; init; }

    [JsonPropertyName("OutputContent")]
    public required OutputContent2 OutputContent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MenuEntry")]
    public IReadOnlyList<MenuEntry>? MenuEntry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OutputSignature")]
    [RegularExpression("^.+$")]
    public string? OutputSignature { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MinLength")]
    public int? MinLength { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxLength")]
    public int? MaxLength { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxDecimalLength")]
    public int? MaxDecimalLength { get; init; }
}
