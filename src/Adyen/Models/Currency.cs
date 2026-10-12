using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Currency
{
    /// <summary>
    /// Surcharge amount per transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    /// <summary>
    /// Three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>. For example, <b>AUD</b>.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; init; }

    /// <summary>
    /// The maximum surcharge amount per transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public int? MaxAmount { get; init; }

    /// <summary>
    /// Surcharge percentage per transaction. The maximum number of decimal places is two. For example, <b>1%</b> or <b>2.27%</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    public double? Percentage { get; init; }
}
