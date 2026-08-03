using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the balances of the disbursement.
/// </summary>
public record CapitalBalance
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Fee amount.
    /// </summary>
    [JsonPropertyName("fee")]
    public required long Fee { get; init; }

    /// <summary>
    /// Principal amount.
    /// </summary>
    [JsonPropertyName("principal")]
    public required long Principal { get; init; }

    /// <summary>
    /// Total amount. A sum of principal amount and fee amount.
    /// </summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }
}
