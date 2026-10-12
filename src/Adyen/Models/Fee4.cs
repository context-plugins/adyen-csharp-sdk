using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// An object containing the fee currency and value, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
/// </summary>
public record Fee4
{
    /// <summary>
    /// Contains the fee amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
