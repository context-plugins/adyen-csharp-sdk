using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// An object specifying the currency and value to which you want to convert the source amount (the target amount).
/// </summary>
public record Amount34
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The amount of the transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes#minor-units">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}
