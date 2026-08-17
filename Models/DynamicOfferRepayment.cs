using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DynamicOfferRepayment
{
    /// <summary>
    /// Contains information about the time period in which your user must repay the total amount of the grant.
    /// </summary>
    [JsonPropertyName("term")]
    public required RepaymentTerm Term { get; init; }
}
