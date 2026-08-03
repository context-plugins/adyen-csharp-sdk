using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the repayment configuration of the grant.
/// </summary>
public record DynamicOfferRepayment2
{
    [JsonPropertyName("term")]
    public required Term Term { get; init; }
}
