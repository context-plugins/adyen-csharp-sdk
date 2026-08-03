using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the fee that your user must pay for the disbursement.
/// </summary>
public record Fee21
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }
}
