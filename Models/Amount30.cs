using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The updated amount.
/// </summary>
public record Amount30
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see> of the amount.
    /// </summary>
    [JsonPropertyName("currency")]
    [StringLength(3, MinimumLength = 3)]
    public required string Currency { get; init; }

    /// <summary>
    /// The numeric value of the amount, in <see href="https://docs.adyen.com/development-resources/currency-codes#minor-units">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
