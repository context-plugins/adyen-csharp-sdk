using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record HomePhone
{
    /// <summary>
    /// Country code. Length: 1–3 digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc")]
    [StringLength(3, MinimumLength = 1)]
    public string? Cc { get; init; }

    /// <summary>
    /// Subscriber number. Length: 4-15  digits.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscriber")]
    [MaxLength(15)]
    public string? Subscriber { get; init; }
}
