using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of the EventNotification message.
/// </summary>
public record EventNotification2
{
    /// <summary>
    /// Date and time of a transaction for the Sale System, the POI System or the Acquirer.
    /// </summary>
    [JsonPropertyName("TimeStamp")]
    public required DateTimeOffset TimeStamp { get; init; }

    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// Possible values:
    /// * <b>Abort</b>
    /// * <b>BeginMaintenance</b>
    /// * <b>CardInserted</b>
    /// * <b>CardRemoved</b>
    /// * <b>Completed</b>
    /// * <b>CustomerLanguage</b>
    /// * <b>EndMaintenance</b>
    /// * <b>Initialised</b>
    /// * <b>KeyPressed</b>
    /// * <b>OutOfOrder</b>
    /// * <b>Reject</b>
    /// * <b>SaleAdmin</b>
    /// * <b>SaleWakeUp</b>
    /// * <b>ScanBarcodeResult</b>
    /// * <b>SecurityAlarm</b>
    /// * <b>Shutdown</b>
    /// * <b>StopAssistance</b>
    /// * <b>UseAnotherCardForPreauth</b>
    /// </summary>
    [JsonPropertyName("EventToNotify")]
    public required EventToNotify1 EventToNotify { get; init; }

    /// <summary>
    /// Information about the event the POI notifies to the Sale System.
    /// If present, the Sale logs it for further examination.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EventDetails")]
    [RegularExpression("^.+$")]
    public string? EventDetails { get; init; }

    /// <summary>
    /// Message request rejected by the receiver.
    /// Mandatory if EventToNotify is Reject, absent in other cases.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RejectedMessage")]
    [RegularExpression("^.+$")]
    public string? RejectedMessage { get; init; }

    /// <summary>
    /// Indicates if the occurred event requires maintenance call or action.
    /// </summary>
    [JsonPropertyName("MaintenanceRequiredFlag")]
    public bool? MaintenanceRequiredFlag { get; init; } = false;

    /// <summary>
    /// Information to display and the way to process the display.
    /// To display an event message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public IReadOnlyList<DisplayOutput>? DisplayOutput { get; init; }
}
