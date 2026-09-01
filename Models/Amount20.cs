using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Amount20
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
