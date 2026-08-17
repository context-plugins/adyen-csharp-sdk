using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The status of the new account holder.
/// </summary>
public record AccountHolderStatus2
{
    /// <summary>
    /// A list of events scheduled for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("events")]
    public IReadOnlyList<AccountEvent>? Events { get; init; }

    /// <summary>
    /// The payout state of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutState")]
    public AccountPayoutState2? PayoutState { get; init; }

    /// <summary>
    /// The processing state of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingState")]
    public AccountProcessingState2? ProcessingState { get; init; }

    /// <summary>
    /// The status of the account holder.
    /// &gt;Permitted values: <c>Active</c>, <c>Inactive</c>, <c>Suspended</c>, <c>Closed</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status12 Status { get; init; }

    /// <summary>
    /// The reason why the status was assigned to the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusReason")]
    public string? StatusReason { get; init; }
}
