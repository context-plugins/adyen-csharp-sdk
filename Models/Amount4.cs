using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The maximum amount that payouts are limited to. Only applies if payouts are allowed but limited.
/// </summary>
public record Amount4
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
