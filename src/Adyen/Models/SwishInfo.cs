using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SwishInfo
{
    /// <summary>
    /// Swish number. Format: 10 digits without spaces. For example, <b>1231111111</b>.
    /// </summary>
    [JsonPropertyName("swishNumber")]
    [StringLength(10, MinimumLength = 10)]
    public required string SwishNumber { get; init; }
}
