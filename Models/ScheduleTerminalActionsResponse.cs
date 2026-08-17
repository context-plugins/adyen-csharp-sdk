using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.OneOf;

namespace Adyen.Models;

public record ScheduleTerminalActionsResponse
{
    /// <summary>
    /// Information about the action to take.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionDetails")]
    public ActionDetails? ActionDetails { get; init; }

    /// <summary>
    /// A list containing a terminal ID and an action ID for each terminal that the action was scheduled for.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<TerminalActionScheduleDetail>? Items { get; init; }

    /// <summary>
    /// The date and time when the action should happen.
    /// Format: <see href="https://www.rfc-editor.org/rfc/rfc3339">RFC 3339</see>, but without the <b>Z</b> before the time offset. For example, <b>2021-11-15T12:16:21+0100</b>
    /// The action is sent with the first <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api#when-actions-take-effect">maintenance call</see> after the specified date and time in the time zone of the terminal.
    /// An empty value causes the action to be sent as soon as possible: at the next maintenance call.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduledAt")]
    public string? ScheduledAt { get; init; }

    /// <summary>
    /// The unique ID of the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores">store</see>. If present, all terminals in the <c>terminalIds</c> list must be assigned to this store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }

    /// <summary>
    /// The validation errors that occurred in the list of terminals, and for each error the IDs of the terminals that the error applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalsWithErrors")]
    public IReadOnlyDictionary<string, object>? TerminalsWithErrors { get; init; }

    /// <summary>
    /// The number of terminals for which scheduling the action failed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalErrors")]
    public int? TotalErrors { get; init; }

    /// <summary>
    /// The number of terminals for which the action was successfully scheduled. This doesn't mean the action has happened yet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalScheduled")]
    public int? TotalScheduled { get; init; }
}
