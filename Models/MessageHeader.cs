using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Message header of the Sale to POI protocol message.
/// It conveys Information related to the Sale to POI protocol management.
/// </summary>
public record MessageHeader
{
    /// <summary>
    /// If MessageCategory is Login or Diagnosis.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtocolVersion")]
    [RegularExpression("^.+$")]
    public string? ProtocolVersion { get; init; }

    /// <summary>
    /// Class of the message.
    /// Possible values:
    /// * <b>Device</b>
    /// * <b>Event</b>
    /// * <b>Service</b>
    /// </summary>
    [JsonPropertyName("MessageClass")]
    public required MessageClass1 MessageClass { get; init; }

    /// <summary>
    /// Category of message.
    /// Possible values:
    /// * <b>Abort</b>
    /// * <b>Admin</b>
    /// * <b>BalanceInquiry</b>
    /// * <b>Batch</b>
    /// * <b>CardAcquisition</b>
    /// * <b>CardReaderInit</b>
    /// * <b>CardReaderPowerOff</b>
    /// * <b>Diagnosis</b>
    /// * <b>Display</b>
    /// * <b>EnableService</b>
    /// * <b>Event</b>
    /// * <b>GetTotals</b>
    /// * <b>Input</b>
    /// * <b>InputUpdate</b>
    /// * <b>Login</b>
    /// * <b>Logout</b>
    /// * <b>Loyalty</b>
    /// * <b>None</b>
    /// * <b>PIN</b>
    /// * <b>Payment</b>
    /// * <b>Print</b>
    /// * <b>Reconciliation</b>
    /// * <b>Reversal</b>
    /// * <b>Sound</b>
    /// * <b>StoredValue</b>
    /// * <b>TransactionStatus</b>
    /// * <b>Transmit</b>
    /// </summary>
    [JsonPropertyName("MessageCategory")]
    public required MessageCategory1 MessageCategory { get; init; }

    /// <summary>
    /// Type of message of the Sale to POI protocol.
    /// Possible values:
    /// * <b>Notification</b>
    /// * <b>Request</b>
    /// * <b>Response</b>
    /// </summary>
    [JsonPropertyName("MessageType")]
    public required MessageType1 MessageType { get; init; }

    /// <summary>
    /// Identification of a message pair, which processes a transaction.
    /// Required if Service or Event MessageClass message or if Device MessageClass and request from POI or response from Sale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServiceID")]
    [RegularExpression("^.{1,10}$")]
    public string? ServiceId { get; init; }

    /// <summary>
    /// Identification of a device message pair.
    /// If Device MessageClass.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DeviceID")]
    [RegularExpression("^.{1,10}$")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// Identification of a Sale System or a Sale Terminal for the Sale to POI protocol.
    /// </summary>
    [JsonPropertyName("SaleID")]
    [RegularExpression("^.+$")]
    public required string SaleId { get; init; }

    /// <summary>
    /// Identification of a POI System or a POI Terminal for the Sale to POI protocol.
    /// </summary>
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public required string Poiid { get; init; }
}
