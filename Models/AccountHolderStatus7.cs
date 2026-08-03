using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The new status of the account holder.
/// </summary>
public record AccountHolderStatus7
{
    /// <summary>
    /// A list of events scheduled for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    public IReadOnlyList<AccountEvent>? Events { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutState")]
    public AccountPayoutState? PayoutState { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingState")]
    public AccountProcessingState? ProcessingState { get; init; }

    [JsonPropertyName("status")]
    public required Status1 Status { get; init; }

    /// <summary>
    /// The reason why the status was assigned to the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public string? StatusReason { get; init; }
}
