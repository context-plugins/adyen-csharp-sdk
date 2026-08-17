using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The amount of the payment.
/// </summary>
public record Amount110
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO 4217 currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    [MinLength(1)]
    public required string Currency { get; init; }

    /// <summary>
    /// The amount of the transaction in <see href="https://docs.adyen.com/development-resources/currency-codes#minor-units">minor units</see> (cents).
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
