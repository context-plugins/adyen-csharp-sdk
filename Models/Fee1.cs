using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details of the fee configuration.
/// </summary>
public record Fee1
{
    /// <summary>
    /// Contains the fee amount.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
