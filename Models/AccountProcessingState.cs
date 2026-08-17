using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountProcessingState
{
    /// <summary>
    /// The reason why processing has been disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disableReason")]
    public string? DisableReason { get; init; }

    /// <summary>
    /// Indicates whether the processing of payments is allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// The lower bound of the processing tier (i.e., an account holder must have processed at least this amount of money in order to be placed into this tier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processedFrom")]
    public Amount? ProcessedFrom { get; init; }

    /// <summary>
    /// The upper bound of the processing tier (i.e., an account holder must have processed less than this amount of money in order to be placed into this tier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processedTo")]
    public Amount? ProcessedTo { get; init; }

    /// <summary>
    /// The processing tier that the account holder occupies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tierNumber")]
    public int? TierNumber { get; init; }
}
