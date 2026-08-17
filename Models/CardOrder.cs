using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CardOrder
{
    /// <summary>
    /// The date when the card order is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("beginDate")]
    public DateTimeOffset? BeginDate { get; init; }

    /// <summary>
    /// The unique identifier of the card manufacturer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardManufacturingProfileId")]
    public string? CardManufacturingProfileId { get; init; }

    /// <summary>
    /// The date when the card order processing ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closedDate")]
    public DateTimeOffset? ClosedDate { get; init; }

    /// <summary>
    /// The date when you manually closed the card order.
    /// <para>
    /// Card orders are automatically closed by the end of the day it was created. If you manually closed it beforehand, the closing date is shown as the <c>endDate</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endDate")]
    public DateTimeOffset? EndDate { get; init; }

    /// <summary>
    /// The unique identifier of the card order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The date when the card order processing begins.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lockDate")]
    public DateTimeOffset? LockDate { get; init; }

    /// <summary>
    /// The service center.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceCenter")]
    public string? ServiceCenter { get; init; }

    /// <summary>
    /// The status of the card order.
    /// <para>
    /// Possible values: <b>Open</b>, <b>Closed</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status61? Status { get; init; }
}
