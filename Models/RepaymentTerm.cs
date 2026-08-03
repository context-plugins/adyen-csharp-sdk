using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the time period in which your user must repay the total amount of the grant.
/// </summary>
public record RepaymentTerm
{
    /// <summary>
    /// The estimated term for repaying the grant, in days.
    /// </summary>
    [JsonPropertyName("estimatedDays")]
    public required int EstimatedDays { get; init; }

    /// <summary>
    /// The maximum term for repaying the grant, in days. Only applies when <c>contractType</c> is <b>loan</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maximumDays")]
    public int? MaximumDays { get; init; }
}
