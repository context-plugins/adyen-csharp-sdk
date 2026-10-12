using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Identification of a previous POI transaction.
/// </summary>
public record MessageReference4
{
    /// <summary>
    /// Category of message.
    /// CardAcquisition, Display, Input, Loyalty, Payment, Print, CardReaderInit, CardReaderPowerOff.
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MessageCategory")]
    public MessageCategory2? MessageCategory { get; init; }

    /// <summary>
    /// Identification of a message pair, which processes a transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServiceID")]
    [RegularExpression("^.{1,10}$")]
    public string? ServiceId { get; init; }

    /// <summary>
    /// Identification of a device message pair.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DeviceID")]
    [RegularExpression("^.{1,10}$")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// Identification of a Sale System or a Sale Terminal for the Sale to POI protocol.
    /// default MessageHeader.SaleID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleID")]
    [RegularExpression("^.+$")]
    public string? SaleId { get; init; }

    /// <summary>
    /// Identification of a POI System or a POI Terminal for the Sale to POI protocol.
    /// Default <c>MessageHeader.POIID</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public string? Poiid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
