using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateTransferLimitRequest
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }

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
    /// Your reference for the transfer limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaInformation")]
    public CreateScaInformation? ScaInformation { get; init; }

    [JsonPropertyName("scope")]
    public required Scope Scope { get; init; }

    /// <summary>
    /// The date and time when the transfer limit becomes active. If you specify a date in the future, we will schedule a transfer limit.
    /// <para>
    /// Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: <b>YYYY-MM-DDThh:mm:ss.sssTZD</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startsAt")]
    public DateTimeOffset? StartsAt { get; init; }

    [JsonPropertyName("transferType")]
    public required TransferType TransferType { get; init; }
}
