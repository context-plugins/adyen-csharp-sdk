using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the currency and value of the cashout fee, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
/// </summary>
public record Fee21
{
    /// <summary>
    /// Contains the fee amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
