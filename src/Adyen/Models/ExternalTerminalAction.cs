using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ExternalTerminalAction
{
    /// <summary>
    /// The type of terminal action: <b>InstallAndroidApp</b>, <b>UninstallAndroidApp</b>, <b>InstallAndroidCertificate</b>, or <b>UninstallAndroidCertificate</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("actionType")]
    public string? ActionType { get; init; }

    /// <summary>
    /// Technical information about the terminal action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("config")]
    public string? Config { get; init; }

    /// <summary>
    /// The date and time when the action was carried out.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confirmedAt")]
    public DateTimeOffset? ConfirmedAt { get; init; }

    /// <summary>
    /// The unique ID of the terminal action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The result message for the action.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public string? Result { get; init; }

    /// <summary>
    /// The date and time when the action was scheduled to happen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduledAt")]
    public DateTimeOffset? ScheduledAt { get; init; }

    /// <summary>
    /// The status of the terminal action: <b>pending</b>, <b>successful</b>, <b>failed</b>, <b>cancelled</b>, or <b>tryLater</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The unique ID of the terminal that the action applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalId")]
    public string? TerminalId { get; init; }
}
