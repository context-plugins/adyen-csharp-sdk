using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Term
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
