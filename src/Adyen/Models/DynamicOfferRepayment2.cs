using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Contains information about the repayment configuration of the grant.
/// </summary>
public record DynamicOfferRepayment2
{
    /// <summary>
    /// Contains information about the time period in which your user must repay the total amount of the grant.
    /// </summary>
    [JsonPropertyName("term")]
    public required RepaymentTerm Term { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
