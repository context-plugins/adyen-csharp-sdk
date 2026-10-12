using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SwishResponseInfo
{
    /// <summary>
    /// Swish number. Format: 10 digits without spaces. For example, <b>1231111111</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swishNumber")]
    [StringLength(10, MinimumLength = 10)]
    public string? SwishNumber { get; init; }
}
