using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record Repayment1
{
    /// <summary>
    /// The percentage of your user's incoming net volume that is deducted for repaying the grant. The percentage expressed in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
    /// </summary>
    [JsonPropertyName("basisPoints")]
    public required int BasisPoints { get; init; }

    /// <summary>
    /// Contains information about the time period in which your user must repay the total amount of the grant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("term")]
    public RepaymentTerm? Term { get; init; }

    /// <summary>
    /// Contains the minimum threshold amount that your user must repay every 30-day period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threshold")]
    public ThresholdRepayment21? Threshold { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
