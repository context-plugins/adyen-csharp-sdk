using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details of the fee configuration.
/// </summary>
public record Fee1
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
