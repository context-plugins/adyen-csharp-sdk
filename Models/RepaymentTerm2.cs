using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// An object containing the details of the configuration for repayment term.
/// </summary>
public record RepaymentTerm2
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
