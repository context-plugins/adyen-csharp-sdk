using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The transfer limit configured to regulate outgoing transfers.
/// </summary>
public record TransferLimit
{
    /// <summary>
    /// The amount for the transfer limit. This is the maximum amount allowed per transfer or per day based on the <c>scope</c> of the limit.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// The date and time when the transfer limit becomes inactive. If you do not specify an end date, the limit stays active until you override it with a new limit.
    /// <para>
    /// Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: <b>YYYY-MM-DDThh:mm:ss.sssTZD</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endsAt")]
    public DateTimeOffset? EndsAt { get; init; }

    /// <summary>
    /// The unique identifier of the transfer limit.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The status of the transfer limit. Possible values:
    /// * <b>active</b>: the limit is currently active.
    /// * <b>inactive</b>: the limit is currently inactive.
    /// * <b>pendingSCA</b>: the limit is pending until your user performs SCA.
    /// * <b>scheduled</b>: the limit is scheduled to become active at a future date.
    /// </summary>
    [JsonPropertyName("limitStatus")]
    public required LimitStatus LimitStatus { get; init; }

    /// <summary>
    /// Your reference for the transfer limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// Information for the Strong Customer Authentication (SCA)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaInformation")]
    public ScaInformation1? ScaInformation { get; init; }

    /// <summary>
    /// The scope to which the transfer limit applies. Possible values:
    /// * <b>perTransaction</b>: you set a maximum amount for each transfer made from the balance account or balance platform.
    /// * <b>perDay</b>: you set a maximum total amount for all transfers made from the balance account or balance platform in a day.
    /// </summary>
    [JsonPropertyName("scope")]
    public required Scope Scope { get; init; }

    /// <summary>
    /// The date and time when the transfer limit becomes active. If you specify a date in the future, we will schedule a transfer limit.
    /// <para>
    /// Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: <b>YYYY-MM-DDThh:mm:ss.sssTZD</b>
    /// </para>
    /// </summary>
    [JsonPropertyName("startsAt")]
    public required DateTimeOffset StartsAt { get; init; }

    /// <summary>
    /// The type of transfer to which the limit applies. Possible values:
    /// * <b>instant</b>: the limit applies to transfers with an <b>instant</b> priority.
    /// * <b>all</b>: the limit applies to all transfers, regardless of priority.
    /// </summary>
    [JsonPropertyName("transferType")]
    public required TransferType TransferType { get; init; }
}
