using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferEvent
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount5? Amount { get; init; }

    /// <summary>
    /// The amount adjustments in this transfer. Only applicable for <see href="https://docs.adyen.com/issuing/">issuing</see> integrations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountAdjustments")]
    public IReadOnlyList<AmountAdjustment>? AmountAdjustments { get; init; }

    /// <summary>
    /// Scheme unique arn identifier useful for tracing captures, chargebacks, refunds, etc.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("arn")]
    public string? Arn { get; init; }

    /// <summary>
    /// The date when the transfer request was sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bookingDate")]
    public DateTimeOffset? BookingDate { get; init; }

    /// <summary>
    /// The estimated time when the beneficiary should have access to the funds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("estimatedArrivalTime")]
    public DateTimeOffset? EstimatedArrivalTime { get; init; }

    /// <summary>
    /// A list of event data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventsData")]
    public IReadOnlyList<EventsDatum>? EventsData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalReason")]
    public ExternalReason? ExternalReason { get; init; }

    /// <summary>
    /// The unique identifier of the transfer event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modification")]
    public Modification? Modification { get; init; }

    /// <summary>
    /// The list of balance mutations per event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mutations")]
    public IReadOnlyList<BalanceMutation>? Mutations { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalAmount")]
    public OriginalAmount? OriginalAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason2? Reason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status25? Status { get; init; }

    /// <summary>
    /// Additional tracing information for the tracing event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracingData")]
    public TracingData? TracingData { get; init; }

    /// <summary>
    /// Additional information for the tracking event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trackingData")]
    public TrackingData? TrackingData { get; init; }

    /// <summary>
    /// The id of the transaction that is related to this accounting event. Only sent for events of type <b>accounting</b> where the balance changes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionId")]
    public string? TransactionId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type74? Type { get; init; }

    /// <summary>
    /// The date when the tracking status was updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateDate")]
    public DateTimeOffset? UpdateDate { get; init; }

    /// <summary>
    /// The date when the funds are expected to be deducted from or credited to the balance account. This date can be in either the past or future.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valueDate")]
    public DateTimeOffset? ValueDate { get; init; }
}
