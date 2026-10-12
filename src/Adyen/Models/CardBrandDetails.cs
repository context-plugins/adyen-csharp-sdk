using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardBrandDetails
{
    /// <summary>
    /// Indicates if the card supports FSA/HSA healthcare payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healthcare")]
    public bool? Healthcare { get; init; }

    /// <summary>
    /// Indicates if you support the card brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supported")]
    public bool? Supported { get; init; }

    /// <summary>
    /// The name of the card brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
