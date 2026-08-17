using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// State of a POI Terminal.
/// If <c>Response.Result</c> is Success.
/// </summary>
public record PoiStatus1
{
    /// <summary>
    /// Global status of a POI Server or POI Terminal.
    /// Possible values:
    /// * <b>Busy</b>
    /// * <b>Maintenance</b>
    /// * <b>OK</b>
    /// * <b>Unreachable</b>
    /// </summary>
    [JsonPropertyName("GlobalStatus")]
    public required GlobalStatus1 GlobalStatus { get; init; }

    /// <summary>
    /// Indicates if the security module of the POI is working and usable.
    /// If security module present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SecurityOKFlag")]
    public bool? SecurityOkFlag { get; init; }

    /// <summary>
    /// Indicates if the PED is working and usable.
    /// If PED present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PEDOKFlag")]
    public bool? PedokFlag { get; init; }

    /// <summary>
    /// Indicates if the card readers are working and usable.
    /// If card reader device present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderOKFlag")]
    public bool? CardReaderOkFlag { get; init; }

    /// <summary>
    /// Possible values:
    /// * <b>NoPaper</b>
    /// * <b>OK</b>
    /// * <b>OutOfOrder</b>
    /// * <b>PaperJam</b>
    /// * <b>PaperLow</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrinterStatus")]
    public PrinterStatus1? PrinterStatus { get; init; }

    /// <summary>
    /// Indicates if the communication infrastructure is working and usable.
    /// If communication infrastructure present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CommunicationOKFlag")]
    public bool? CommunicationOkFlag { get; init; }

    /// <summary>
    /// Indicates a suspicion of fraud by the POI System.
    /// Could be set to True by the POI system to notify to the Sale system and the Cashier that a suspicion of fraud had been detected on the POI as an unexpected reboot of the POI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FraudPreventionFlag")]
    public bool? FraudPreventionFlag { get; init; }
}
