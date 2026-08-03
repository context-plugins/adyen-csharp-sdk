using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The processing state of the account holder.
/// </summary>
public record AccountProcessingState2
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processedFrom")]
    public ProcessedFrom? ProcessedFrom { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processedTo")]
    public ProcessedTo? ProcessedTo { get; init; }

    /// <summary>
    /// The processing tier that the account holder occupies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tierNumber")]
    public int? TierNumber { get; init; }
}
