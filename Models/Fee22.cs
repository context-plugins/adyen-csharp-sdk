using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the fee that your user must pay for the disbursement.
/// </summary>
public record Fee22
{
    /// <summary>
    /// Contains the amount of the grant fee.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }
}
