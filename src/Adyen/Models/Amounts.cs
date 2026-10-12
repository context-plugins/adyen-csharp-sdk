using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Amounts
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes/">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The amounts of the donation (in <see href="https://docs.adyen.com/development-resources/currency-codes/">minor units</see>).
    /// </summary>
    [JsonPropertyName("values")]
    public required IReadOnlyList<long> Values { get; init; }
}
