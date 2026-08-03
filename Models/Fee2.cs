using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Fee2
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
