using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Indicate the availability of the POI Terminal components. The data element is absent if the component is not part of the POI Terminal.
/// State of a POI Terminal.
/// </summary>
public record Poistatus
{
    [JsonPropertyName("GlobalStatus")]
    public required GlobalStatus1 GlobalStatus { get; init; }

    /// <summary>
    /// Indicates if the security module of the POI is working and usable.
    /// If security module present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SecurityOKFlag")]
    public bool? SecurityOkflag { get; init; }

    /// <summary>
    /// Indicates if the PED is working and usable.
    /// If PED present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PEDOKFlag")]
    public bool? Pedokflag { get; init; }

    /// <summary>
    /// Indicates if the card readers are working and usable.
    /// If card reader device present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderOKFlag")]
    public bool? CardReaderOkflag { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrinterStatus")]
    public PrinterStatus1? PrinterStatus { get; init; }

    /// <summary>
    /// Indicates if the communication infrastructure is working and usable.
    /// If communication infrastructure present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CommunicationOKFlag")]
    public bool? CommunicationOkflag { get; init; }

    /// <summary>
    /// Indicates a suspicion of fraud by the POI System.
    /// Could be set to True by the POI system to notify to the Sale system and the Cashier that a suspicion of fraud had been detected on the POI as an unexpected reboot of the POI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FraudPreventionFlag")]
    public bool? FraudPreventionFlag { get; init; }
}
