using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Fee2
{
    /// <summary>
    /// Contains the amount of the grant fee.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
