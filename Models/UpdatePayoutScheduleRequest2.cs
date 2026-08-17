using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The details of the payout schedule to which the account must be updated.
/// </summary>
public record UpdatePayoutScheduleRequest2
{
    /// <summary>
    /// Direction on how to handle any payouts that have already been scheduled.
    /// <para>
    /// Possible values:
    /// * <c>CLOSE</c>: close the existing batch of payouts.
    /// * <c>UPDATE</c>: reschedule the existing batch to the new schedule.
    /// * <c>NOTHING</c> (<b>default</b>): allow the payout to proceed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; init; }

    /// <summary>
    /// The reason for the payout schedule update.
    /// &gt; This field is required when the <c>schedule</c> parameter is set to <c>HOLD</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The new payout schedule for the account.
    /// <para>
    /// Possible values: <c>DEFAULT</c>, <c>DAILY</c>, <c>DAILY_US</c>, <c>DAILY_EU</c>, <c>DAILY_AU</c>, <c>DAILY_SG</c>, <c>WEEKLY</c>, <c>WEEKLY_ON_TUE_FRI_MIDNIGHT</c>, <c>BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT</c>, <c>MONTHLY</c>, <c>HOLD</c>.
    /// &gt; <c>HOLD</c> prevents scheduled payouts, but you can still initiate payouts manually.
    /// </para>
    /// </summary>
    [JsonPropertyName("schedule")]
    public required Schedule1 Schedule { get; init; }
}
