using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
/// </summary>
public record Amount3
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see> of the amount.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The numeric value of the amount, in <see href="https://docs.adyen.com/development-resources/currency-codes#minor-units">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
