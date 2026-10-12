using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The object that contains the fixed donation amounts that the shopper can select from.
/// </summary>
public record Amounts1
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
