using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>swish</b>.
///  - This field is required only if you have a contract with Swish. Swish handles settlement directly with you (not through Adyen).
///  - If not specified then it's assumed that you are using Adyen's contract with Swish.You don't have a direct relationship with Swish.
/// </summary>
public record SwishInfo2
{
    /// <summary>
    /// Swish number. Format: 10 digits without spaces. For example, <b>1231111111</b>.
    /// </summary>
    [JsonPropertyName("swishNumber")]
    [StringLength(10, MinimumLength = 10)]
    public required string SwishNumber { get; init; }
}
