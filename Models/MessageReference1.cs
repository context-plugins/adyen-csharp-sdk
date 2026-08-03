using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record MessageReference1
{
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
}
