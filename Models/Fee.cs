using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains the currency and value of the cashout fee, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
/// </summary>
public record Fee
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
