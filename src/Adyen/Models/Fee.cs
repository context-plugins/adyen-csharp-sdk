using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Fee
{
    /// <summary>
    /// Contains the fee amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
