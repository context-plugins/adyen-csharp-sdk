using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The upper bound of the processing tier (i.e., an account holder must have processed less than this amount of money in order to be placed into this tier).
/// </summary>
public record Amount21
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    [StringLength(3, MinimumLength = 3)]
    public required string Currency { get; init; }

    /// <summary>
    /// The amount of the transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
